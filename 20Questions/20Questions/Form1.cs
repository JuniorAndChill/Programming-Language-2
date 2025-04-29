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
using System.Diagnostics;
namespace _20Questions
{
    public partial class Form1 : Form
    {
        public class Node //Using linked lists we can get the desired result of a binary tree from file
        {
            public string Data { get; set; } //allows us to track content in a line/row
            public Node YesChild { get; set; } //allows us to track 'yes' type answers
            public Node NoChild { get; set; } //allows us to track 'no' type answers

            public Node(string data) //this whole node thing is really helpful
            {
                Data = data;
                YesChild = null;
                NoChild = null;
            }
        }
        //sets up necessary values for the game
        private Node rootNode;
        private Node currentNode;
        private string currentQuestion = "";
        private bool awaitingNewAnimal = false;
        private bool awaitingNewQuestion = false;
        private string newAnimal = "";
        private bool isInitialQuestion = false; //ensures the 1st question has 'sea' or 'land' buttons...it bugged me

        private Label questionLabel;
        private Button answer1Button;
        private Button answer2Button;
        private Button startButton;
        private Label resultLabel;
        private TextBox newAnswerTextBox;
        private Button submitAnswerButton;
        private Label newQuestionLabel;
        private TextBox newQuestionTextBox;
        private Button submitQuestionButton;

        private string saveFilePath = "game_answers.txt"; //save/load file location to call easier later

        public Form1()
        {
            //all values we need to load to correctly display the game
            InitializeComponent();
            SetupUI();
            LoadGameData();
            StartGame();
        }
        private void SetupUI()
        {
            //using locations and pixel points we can automate the button/field locations. Some tweaking needed to make it perfect
            this.Text = "Binary Tree 20 Questions | Sarah, Jediah, Daniel"; //updates the app name
            this.ClientSize = new Size(500, 500); //updates the app form size

            questionLabel = new Label { AutoSize = true, Location = new Point(20, 20)};
            questionLabel.Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular);
            answer1Button = new Button { Location = new Point(20, 60), Text = "Yes", 
                Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular) ,AutoSize=true};
            answer2Button = new Button { Location = new Point(150, 60), Text = "No", 
                Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular),AutoSize = true};
            startButton = new Button { Text = "Start Game", Location = new Point(20, 100), 
                Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular), AutoSize = true};
            resultLabel = new Label { AutoSize = true, Location = new Point(20, 140), 
                Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular) };
            newAnswerTextBox = new TextBox { Location = new Point(20, 180), Visible = false , 
                Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular) };
            submitAnswerButton = new Button { Text = "Submit Animal", Location = new Point(180, 180), Visible = false , 
                Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular) ,AutoSize = true};
            newQuestionLabel = new Label { AutoSize = true, Location = new Point(20, 220), Text = "Ask a question:", Visible = false , 
                Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular) };
            newQuestionTextBox = new TextBox { Location = new Point(20, 250), Visible = false, 
                Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular) };
            submitQuestionButton = new Button { Text = "Submit Question", Location = new Point(180, 250), Visible = false, 
                Font = new Font(questionLabel.Font.FontFamily, 12, FontStyle.Regular), AutoSize = true};

            //creates object events from objects
            answer1Button.Click += Answer1Button_Click;
            answer2Button.Click += Answer2Button_Click;
            startButton.Click += StartButton_Click;
            submitAnswerButton.Click += SubmitAnswerButton_Click;
            submitQuestionButton.Click += SubmitQuestionButton_Click;

            //define objects that have controls or actions from being used
            Controls.AddRange(new Control[] { questionLabel, answer1Button, answer2Button, startButton, resultLabel, newAnswerTextBox, submitAnswerButton, newQuestionLabel, newQuestionTextBox, submitQuestionButton });

            resultLabel.Visible = false; //hide field before needed
        }
        private void InitializeDefaultData()
        {
            //set paramaters for initial questions if we didn't have a game file. Also sets special case for initial buttons
            rootNode = new Node("Does it live in the sea or on land?");
            rootNode.YesChild = new Node("Whale");
            rootNode.NoChild = new Node("Elephant");

            currentNode = rootNode;
            isInitialQuestion = true;
        }
        private void LoadGameData() //load txt file or create node content to later save to a file
        {
            if (File.Exists(saveFilePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(saveFilePath); //populate binary tree from file into an array...see below
                    if (lines.Length > 0)
                    {
                        int index = 0;
                        rootNode = DeserializeTree(lines, ref index); //turn strings into tree
                    }
                    else
                    {
                        InitializeDefaultData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading game data: {ex.Message}", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InitializeDefaultData();
                }
            }
            else
            {
                InitializeDefaultData();
            }
            currentNode = rootNode;
            isInitialQuestion = (rootNode != null && rootNode.Data == "Does it live in the sea or on land?"); //setting special condition and start point of game
        }
        private void SaveGameData() //save tree to file after inputs
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(saveFilePath))
                {
                    SerializeTree(rootNode, sw);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving game data: {ex.Message}", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //I actually had to look this up for the next 2. For binary tree algorithims we make use of deserialized and serialized trees.
        //basically we convert objects/data structures into a sequence of bits or memory buffer. It's specifcally for binary tree alg
        private Node DeserializeTree(string[] lines, ref int index) //turns string of data into a tree structure
        {
            if (index >= lines.Length || string.IsNullOrEmpty(lines[index]))
            {
                index++;
                return null;
            }

            Node node = new Node(lines[index++]);
            node.YesChild = DeserializeTree(lines, ref index); //sets nodes for yes or no conditions
            node.NoChild = DeserializeTree(lines, ref index);
            return node;
        }
        private void SerializeTree(Node node, StreamWriter sw) //takes tree structure and turns it to a string
        {
            if (node == null)
            {
                sw.WriteLine("");
                return;
            }
            sw.WriteLine(node.Data);
            SerializeTree(node.YesChild, sw); //points data to write in specific location...nodes are great
            SerializeTree(node.NoChild, sw);
        }
        private void StartGame() //all our game start variables
        {
            currentNode = rootNode;
            DisplayCurrentNode();
            startButton.Visible = false;
            resultLabel.Visible = false;
            newAnswerTextBox.Visible = false;
            submitAnswerButton.Visible = false;
            newQuestionLabel.Visible = false;
            newQuestionTextBox.Visible = false;
            submitQuestionButton.Visible = false;
            answer1Button.Visible = true;
            answer2Button.Visible = true;
            awaitingNewAnimal = false;
            awaitingNewQuestion = false;
            newAnimal = ""; //flag for finding empty animal node. Empty string makes more and more sense
            isInitialQuestion = (rootNode != null && rootNode.Data == "Does it live in the sea or on land?"); //man did this really bug me
        }
        private void DisplayCurrentNode() //this points all the data to correct points of the form. It changes as the txt grows. #scalability
        {
            if (currentNode != null)
            {
                currentQuestion = currentNode.Data;
                if (IsQuestion(currentQuestion))
                {
                    questionLabel.Text = currentQuestion;
                    if (isInitialQuestion && currentQuestion == "Does it live in the sea or on land?")
                    {
                        answer1Button.Text = "Sea"; //MY SPECIAL BUTTONS!!!
                        answer2Button.Text = "Land";
                    }
                    else
                    {
                        answer1Button.Text = "Yes";
                        answer2Button.Text = "No";
                    }
                }
                else
                {
                    questionLabel.Text = $"Is it a {currentQuestion}?"; //guess format
                    answer1Button.Text = "Yes, it is!";
                    answer2Button.Text = "No, it's not.";
                }
            }
            else
            {
                questionLabel.Text = "I'm not sure!";
                answer1Button.Visible = false;
                answer2Button.Visible = false;
                awaitingNewAnimal = true;
                newAnswerTextBox.Visible = true;
                submitAnswerButton.Visible = true;
            }
        }
        private bool IsQuestion(string nodeData) //Tags strings that have '?'. everything else is an answer except "" aka empty strings (empty string is important to remember)
        {
            return nodeData.EndsWith("?");
        }

        private void Answer1Button_Click(object sender, EventArgs e) //Represents "Yes" or "Yes, it is!"
        {
            if (awaitingNewAnimal || awaitingNewQuestion || currentNode == null) return;

            if (IsQuestion(currentQuestion))
            {
                currentNode = currentNode.YesChild; //yes tree pointer
                isInitialQuestion = false; //special case button change flag
                DisplayCurrentNode();
            }
            else
            {
                resultLabel.Text = "Great! I guessed it."; //yay
                EndGame();
            }
        }
        private void Answer2Button_Click(object sender, EventArgs e) //Represents "No" or "No, it's not."
        {
            if (awaitingNewAnimal || awaitingNewQuestion || currentNode == null) return;

            if (IsQuestion(currentQuestion))
            {
                if (currentNode.NoChild != null)
                {
                    currentNode = currentNode.NoChild; //no tree pointer
                    isInitialQuestion = false; //special case button change flag
                    DisplayCurrentNode();
                }
                else //this is where the magic happens
                {
                    awaitingNewAnimal = true;
                    questionLabel.Text = "I'm not sure! What were you thinking of?";
                    answer1Button.Visible = false;
                    answer2Button.Visible = false;
                    newAnswerTextBox.Visible = true;
                    submitAnswerButton.Visible = true;
                }
            }
            else //more magic
            {
                awaitingNewAnimal = true;
                questionLabel.Text = "I'm not sure! What were you thinking of?";
                answer1Button.Visible = false;
                answer2Button.Visible = false;
                newAnswerTextBox.Visible = true;
                submitAnswerButton.Visible = true;
            }
        }
        private void SubmitAnswerButton_Click(object sender, EventArgs e) //allows for us to add animals
        {
            if (awaitingNewAnimal && !string.IsNullOrWhiteSpace(newAnswerTextBox.Text))
            {
                string proposedAnimal = newAnswerTextBox.Text.Trim(); //cool trick to remove spaces before and after strings

                //Check if the proposed animal name contains only letters and spaces
                if (proposedAnimal.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    newAnimal = newAnswerTextBox.Text.Trim();
                    awaitingNewAnimal = false;
                    newAnswerTextBox.Visible = false;
                    submitAnswerButton.Visible = false;
                    //question lable will prompt game learning
                    questionLabel.Text = $"Okay, it was a {newAnimal}. Ask a question to distinguish it from {currentNode.Data}:";
                    newQuestionLabel.Visible = true;
                    newQuestionTextBox.Visible = true;
                    submitQuestionButton.Visible = true;
                    awaitingNewQuestion = true;
                }
                else
                {
                    MessageBox.Show("Please enter a valid animal name using only letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newAnswerTextBox.SelectAll(); //another cool trick to highlight all text for override entry
                }
            }
            else if (awaitingNewAnimal && string.IsNullOrWhiteSpace(newAnswerTextBox.Text))
            {
                //we force user input to add valid game expansion
                MessageBox.Show("Please enter the animal.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SubmitQuestionButton_Click(object sender, EventArgs e) //allows for us to add questions
        {
            if (awaitingNewQuestion && !string.IsNullOrWhiteSpace(newQuestionTextBox.Text) && !string.IsNullOrEmpty(newAnimal))
            {
                string newQuestionText = newQuestionTextBox.Text.Trim() + "?"; //just incase user forgets to add '?'. multiple '?' won't mess up the bool
                Node newQuestionNode = new Node(newQuestionText);
                Node correctAnimalNode = new Node(newAnimal);
                Node incorrectGuessNode = new Node(currentNode.Data);

                //the new question replaces the previous leaf (nodes with no children = leaves...ask CMU)
                currentNode.Data = newQuestionText;
                currentNode.YesChild = correctAnimalNode;
                currentNode.NoChild = incorrectGuessNode;

                awaitingNewQuestion = false;
                newQuestionLabel.Visible = false;
                newQuestionTextBox.Visible = false;
                submitQuestionButton.Visible = false;

                SaveGameData();
                resultLabel.Text = "Thanks! The game has learned."; //it's totally not AI but it will feel like it
                StartGame();
            }
            else if (awaitingNewQuestion && string.IsNullOrWhiteSpace(newQuestionTextBox.Text))
            {
                MessageBox.Show("Please enter a distinguishing question.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void StartButton_Click(object sender, EventArgs e) //super simple
        {
            StartGame();
        }

        private void EndGame() //a lot to make sure gets adjusted to make game fluid
        {
            questionLabel.Text = "Game Over!";
            answer1Button.Visible = false;
            answer2Button.Visible = false;
            startButton.Visible = true;
            resultLabel.Visible = true;
            newAnswerTextBox.Visible = false;
            submitAnswerButton.Visible = false;
            newQuestionLabel.Visible = false;
            newQuestionTextBox.Visible = false;
            submitQuestionButton.Visible = false;
            awaitingNewAnimal = false;
            awaitingNewQuestion = false;
            newAnimal = "";
            isInitialQuestion = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
