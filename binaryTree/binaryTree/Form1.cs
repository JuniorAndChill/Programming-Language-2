using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace binaryTree
{
    public partial class Form1 : Form
    {
        private string[] gameTree; // Our array to represent the binary tree
        private int currentQuestionIndex;
        private const int MaxQuestions = 20;
        private const int TreeSize = 1000; // Size of our array

        private const string SaveFilePath = "answers.txt"; // Path to save/load the tree

        public Form1()
        {
            InitializeComponent();
            gameTree = new string[TreeSize];
            LoadGameTree();
            StartNewGame();
        }
        private void LoadGameTree()
        {
            if (File.Exists(SaveFilePath))
            {
                try
                {
                    gameTree = File.ReadAllLines(SaveFilePath);
                    // Resize the array if the file has more lines than our initial size
                    if (gameTree.Length > TreeSize)
                    {
                        Array.Resize(ref gameTree, gameTree.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading game tree: {ex.Message}", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // If loading fails, initialize with the starting question
                    InitializeNewTree();
                }
            }
            else
            {
                // If no file exists, start with the initial question
                InitializeNewTree();
            }
        }
        private void SaveGameTree()
        {
            try
            {
                File.WriteAllLines(SaveFilePath, gameTree.Where(s => !string.IsNullOrEmpty(s))); // Save only non-empty entries
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving game tree: {ex.Message}", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeNewTree()
        {
            // Root question
            gameTree[0] = "Does it live in the sea or on land?";

            // Level 1 - These are now categories, not direct animals
            gameTree[1] = "Sea Creature";
            gameTree[2] = "Land Animal";

            // You might leave subsequent levels empty initially and let the game learn.
        }

        private void StartNewGame()
        {
            currentQuestionIndex = 0;
            AskQuestion(currentQuestionIndex);
            // Enable/disable relevant UI elements for the game
        }
        private void AskQuestion(int index)
        {
            if (index < gameTree.Length && !string.IsNullOrEmpty(gameTree[index]))
            {
                // Check if it's a question or a guess (you'll need a way to differentiate)
                if (IsQuestion(gameTree[index]))
                {
                    // Display the question to the user (e.g., in a Label)
                    // Enable "Yes" and "No" buttons
                    // Store the current index to know where to go next based on the answer
                    // Update UI with the current question
                    string questionText = gameTree[index];
                    // If the question contains placeholders for initial animals, handle that
                    if (questionText.Contains("{") && questionText.Contains("}"))
                    {
                        // Extract and display the initial animal choices
                        // You'll need more sophisticated logic if the tree grows beyond these initial guesses
                        // For now, let's assume the format "Is it a {Animal1} or an {Animal2}?"
                        // You'd extract Animal1 and Animal2 and present the choice.
                        // For simplicity in this initial sketch, let's just display the raw string.
                        UpdateQuestionDisplay(questionText);
                    }
                    else
                    {
                        UpdateQuestionDisplay(questionText);
                    }
                }
                else // It's a guess (an animal)
                {
                    // Ask the user if the guess is correct
                    UpdateQuestionDisplay($"Is it a {gameTree[index]}?");
                    // Disable "Yes" and "No" buttons, enable a "Correct" and "Incorrect" button
                }
            }
            else
            {
                // We've reached the end of a branch without a clear question or guess
                // This might happen if the tree isn't fully built.
                UpdateQuestionDisplay("I'm not sure. What were you thinking of?");
                // Enable a way for the user to tell the game the answer
                // and a distinguishing question.
                EnableLearningMode();
            }

            // Keep track of the number of questions asked (optional, for the 20 question limit)
        }
        private bool IsQuestion(string nodeContent)
        {
            // You'll need a way to determine if a string in your array is a question or an animal.
            // One way is to have a specific prefix for questions (e.g., "Q: ").
            // For now, let's assume if it contains "Does it" or "Is it a", it's a question-like structure.
            return nodeContent.ToLower().StartsWith("does it") || nodeContent.ToLower().StartsWith("is it a");
        }
        private void HandleYesAnswer()
        {
            // Move to the left child: 2 * currentQuestionIndex + 1
            currentQuestionIndex = 2 * currentQuestionIndex + 1;
            if (currentQuestionIndex < gameTree.Length)
            {
                AskQuestion(currentQuestionIndex);
            }
            else
            {
                // Reached the end of the array unexpectedly
                UpdateQuestionDisplay("Hmm, something went wrong in the tree structure.");
                EnableLearningMode();
            }
        }
        private void HandleNoAnswer()
        {
            // Move to the right child: 2 * currentQuestionIndex + 2
            currentQuestionIndex = 2 * currentQuestionIndex + 2;
            if (currentQuestionIndex < gameTree.Length)
            {
                AskQuestion(currentQuestionIndex);
            }
            else
            {
                // Reached the end of the array unexpectedly
                UpdateQuestionDisplay("Hmm, something went wrong in the tree structure.");
                EnableLearningMode();
            }
        }
        private void HandleCorrectGuess()
        {
            UpdateQuestionDisplay("Great! I guessed it.");
            SaveGameTree();
            // Optionally start a new game
        }

        private void HandleIncorrectGuess()
        {
            UpdateQuestionDisplay("Oh, I was wrong. What were you thinking of?");
            EnableLearningMode();
        }
        private void EnableLearningMode()
        {
            // Enable UI elements for the user to provide the correct animal
            // and a question to distinguish it from the game's incorrect guess.
            // You'll need TextBoxes for input and a Button to submit the new information.
        }
        private void LearnNewAnimal(string correctAnimal, string distinguishingQuestion)
        {
            // The 'currentQuestionIndex' at this point would have led to the incorrect guess.
            // That index now needs to hold the new distinguishing question.
            string incorrectGuess = gameTree[currentQuestionIndex]; // The animal the game guessed

            gameTree[currentQuestionIndex] = distinguishingQuestion;

            // You need to find two empty spots in the array to store the correct animal
            // and the incorrect guess, as children of the new question.
            int leftChildIndex = FindNextEmptyIndex();
            if (leftChildIndex < TreeSize)
            {
                gameTree[leftChildIndex] = correctAnimal;
                int rightChildIndex = FindNextEmptyIndex();
                if (rightChildIndex < TreeSize)
                {
                    gameTree[rightChildIndex] = incorrectGuess;
                    // You'll need to determine if the 'yes' or 'no' answer to the
                    // 'distinguishingQuestion' leads to the 'correctAnimal'.
                    // This will likely involve another question to the user.
                    AskWhichAnswerLeadsToCorrectAnimal(distinguishingQuestion, correctAnimal, incorrectGuess, currentQuestionIndex, leftChildIndex, rightChildIndex);
                }
                else
                {
                    MessageBox.Show("Error: Could not find space for the incorrect guess.", "Learning Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Could not find space for the correct animal.", "Learning Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // After learning, save the updated tree
            SaveGameTree();
            // Optionally start a new game
        }
        private void AskWhichAnswerLeadsToCorrectAnimal(string question, string correctAnimal, string incorrectAnimal, int parentIndex, int correctIndex, int incorrectIndex)
        {
            // Display a message asking the user:
            // "For the question '{question}', does the answer 'yes' or 'no' lead to '{correctAnimal}'?"
            // Based on the user's response, you'll need to ensure the correct animal and
            // incorrect animal are placed in the correct left/right child positions
            // of the 'question' at 'parentIndex'. You might need to swap them in the array
            // if the user says 'no' leads to the correct animal.

            // For simplicity in this initial sketch, let's assume 'yes' always leads to the correct animal.
            // In a real implementation, you'd handle the user's choice.
        }

        private int FindNextEmptyIndex()
        {
            for (int i = 0; i < gameTree.Length; i++)
            {
                if (string.IsNullOrEmpty(gameTree[i]))
                {
                    return i;
                }
            }
            return -1; // Array is full
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Question_Click(object sender, EventArgs e)
        {

        }

        private void UpdateQuestionDisplay(string text)
        {
            // Assuming you have a Label control named 'questionLabel' on your form
            lbl_Question.Text = text;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            StartNewGame();
            lbl_Question.Visible = true;
            btn_Yes.Visible = true;
            btn_No.Visible = true;
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            HandleYesAnswer();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            HandleNoAnswer();
        }


        // This is a binary tree 20 questions game. As the game goes on, the game gets larger
        // After the game it writes all the arr elements to a txt file to be read the next game
        // 2^0  starting question: "Does it live in the sea or on land?"
        // 2^1  starting animals: "Is it a {Whale} + "or an " +{Elephant} + "?"
        // 2^3  in element 4 and 5: no flag (function to add new user input answer) & yes flag (ends game) ....in element 6 and 7: no flag (function to add new user input answer) & yes flag (ends game)
        // Continue pattern till 20 questions were prompted

        // string arr [1000];
        // Using streamreader sr = [insert path] {for (int i =1; i < sr[lines] -1; i++){Readline() -> to arr[1000]}
    }
}
