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

namespace uno_ColorAdd
{
    public partial class Form1 : Form
    {
        // Containers for players, cards, fields
        private List<PictureBox> cardPictureBoxes = new List<PictureBox>();
        private List<UnoCard> deck = new List<UnoCard>();
        private List<UnoCard> discardPile = new List<UnoCard>();
        private List<List<UnoCard>> playerHands = new List<List<UnoCard>>();
        private List<Panel> playerHandPanels = new List<Panel>();
        private int currentPlayerIndex = 0; // player starting point
        private int numberOfPlayers = 4;
        private PictureBox draggedCard = null; // initial drag state

        public Form1()
        {
            InitializeComponent();
            InitializePanels();
            InitializeButtons();
            InitializeLabels();
            InitializeUnoDeck();
            InitializeZoomedCardPictureBox();
            InitializeCardControls();
            StartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializePanels()
        {
            // Creates and places discard pile with default background
            discardPilePanel = new Panel();
            discardPilePanel.Location = new Point(this.ClientSize.Width / 2 - 50, this.ClientSize.Height / 2 - 75);
            discardPilePanel.Size = new Size(100, 150);
            discardPilePanel.BackColor = Color.LightGray;
            this.Controls.Add(discardPilePanel);

            // Creates and places deck pile and updates display (card backs)
            deckPilePanel = new Panel();
            deckPilePanel.Location = new Point(this.ClientSize.Width / 2 - 150, this.ClientSize.Height / 2 - 75);
            deckPilePanel.Size = new Size(100, 150);
            deckPilePanel.Click += DeckPilePanel_Click;
            this.Controls.Add(deckPilePanel);
            UpdateDeckPileDisplay();

            // Sets padding
            int panelWidth = this.ClientSize.Width / 2 - 20;
            int panelHeight = 160;

            // Creates and places player hands with autoscroll to solve clipping
            playerHandPanels.Add(new FlowLayoutPanel() { Location = new Point(10, this.ClientSize.Height - panelHeight - 10), Size = new Size(panelWidth, panelHeight), AutoScroll = true });
            playerHandPanels.Add(new FlowLayoutPanel() { Location = new Point(this.ClientSize.Width / 2 + 10, this.ClientSize.Height - panelHeight - 10), Size = new Size(panelWidth, panelHeight), AutoScroll = true });
            playerHandPanels.Add(new FlowLayoutPanel() { Location = new Point(10, 10), Size = new Size(panelWidth, panelHeight), AutoScroll = true });
            playerHandPanels.Add(new FlowLayoutPanel() { Location = new Point(this.ClientSize.Width / 2 + 10, 10), Size = new Size(panelWidth, panelHeight), AutoScroll = true });

            // Evaluates player hands and deals cards from deck list
            foreach (var panel in playerHandPanels)
            {
                this.Controls.Add(panel);
                playerHands.Add(new List<UnoCard>());
            }
        }

        private void InitializeButtons()
        {
            // Creates and places buttons. Adds on-click event detection
            unoButton = new Button() { Location = new Point(230, this.ClientSize.Height - 200), Text = "UNO!" };
            drawButton = new Button() { Location = new Point(120, this.ClientSize.Height - 200), Text = "Draw Card" };
            drawButton.Click += DrawButton_Click1;
            unoButton.Click += UnoButton_Click;
            this.Controls.Add(drawButton);
            this.Controls.Add(unoButton);
        }

        private void DrawButton_Click1(object sender, EventArgs e)
        {
            // Logic for adding cards on DrawCard() and passes to next player
            DrawCard(playerHands[currentPlayerIndex]);
            NextPlayer();
        }

        private void InitializeLabels()
        {
            // Creates and places turn label
            currentPlayerLabel = new Label() { Location = new Point(this.ClientSize.Width / 2 - 100, this.ClientSize.Height - 200), Text = $"Player {currentPlayerIndex + 1}'s Turn" };
            currentPlayerLabel.BackColor = Color.LightGray;
            currentPlayerLabel.Font = new Font(currentPlayerLabel.Font.FontFamily, 12);
            currentPlayerLabel.AutoSize = true;
            this.Controls.Add(currentPlayerLabel);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
        }

        // Custom UNO! message box and functions
        private void UnoButton_Click(object sender, EventArgs e)
        {
            unoCalled = true;

            // Create a new Form for the UNO message
            Form unoMessageForm = new Form();
            unoMessageForm.Text = "UNO!";
            unoMessageForm.ClientSize = new Size(300, 150); // Size of popup box
            unoMessageForm.StartPosition = FormStartPosition.CenterParent; // Display off of game form
            unoMessageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            unoMessageForm.MinimizeBox = false;
            unoMessageForm.MaximizeBox = false;

            // Create a Label for the message
            Label messageLabel = new Label();
            messageLabel.Text = $"Player {currentPlayerIndex + 1} declared UNO!";
            messageLabel.AutoSize = true; // Adjust label size to text
            messageLabel.Font = new Font("Arial", 16); // Set font and size 
            messageLabel.Location = new Point(10, 10); // Position of the label
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Create an OK button
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(unoMessageForm.ClientSize.Width / 2 - okButton.Width / 2, unoMessageForm.ClientSize.Height - okButton.Height - 10);

            // Add controls to the form
            unoMessageForm.Controls.Add(messageLabel);
            unoMessageForm.Controls.Add(okButton);

            // Show the form as a dialog
            unoMessageForm.ShowDialog();
        }
        // Deck creation and concatnation
        private void InitializeUnoDeck()
        {
            string[] colors = { "red", "yellow", "green", "blue", "wild" };
            string[] values = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "skip", "reverse", "draw2", "wild", "wilddraw4" };

            foreach (string color in colors)
            {
                // Only process wild cards for "wild" color.
                if (color == "wild")
                {
                    foreach (string value in new[] { "wild", "wilddraw4" })
                    {
                        string imageName = Path.Combine("C:\\Users\\dj_dc\\OneDrive\\Desktop\\Programming Language 2\\uno_ColorAdd\\img", $"{color}_{value}.png");
                        for (int i = 0; i < 4; i++)
                        {
                            deck.Add(new UnoCard(color, value, imageName, true));
                        }
                    }
                }
                else // Process colored cards.
                {
                    foreach (string value in new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "skip", "reverse", "draw2" })
                    {
                        string imageName = Path.Combine("C:\\Users\\dj_dc\\OneDrive\\Desktop\\Programming Language 2\\uno_ColorAdd\\img", $"{color}_{value}.png");
                        deck.Add(new UnoCard(color, value, imageName, false));
                        if (value != "0")
                        {
                            deck.Add(new UnoCard(color, value, imageName, false));
                        }
                    }
                }
            }
        }
        // Drag drop funtionality
        private void InitializeCardControls()
        {
            discardPilePanel.AllowDrop = true;
            discardPilePanel.DragEnter += discardPilePanel_DragEnter;
            discardPilePanel.DragDrop += discardPilePanel_DragDrop;
        }
        // Creates blown up view of cards for readability
        private void InitializeZoomedCardPictureBox()
        {
            zoomedCardPictureBox = new PictureBox();
            zoomedCardPictureBox.Size = new Size(200, 300); // 200% view
            zoomedCardPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            zoomedCardPictureBox.Visible = false;
            this.Controls.Add(zoomedCardPictureBox);
        }
        // Zoom event creation and logic
        private void CardPictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox cardPictureBox = (PictureBox)sender;
            zoomedCardPictureBox.Image = cardPictureBox.Image;
            zoomedCardPictureBox.Location = new Point(this.ClientSize.Width - zoomedCardPictureBox.Width - 10, this.ClientSize.Height / 2 - zoomedCardPictureBox.Height / 2);
            zoomedCardPictureBox.Visible = true;
        }
        // Zoom event-end
        private void CardPictureBox_MouseLeave(object sender, EventArgs e)
        {
            zoomedCardPictureBox.Visible = false;
        }
        // Deck click-to-draw feature. troubleshoot later
        private void DeckPilePanel_Click(object sender, EventArgs e)
        {

        }
        // Draw card logic. Reshuffle and error handling included
        private void DrawCard(List<UnoCard> hand)
        {
            if (deck.Count == 0)
            {
                ReshuffleDiscardPile();
                UpdateDeckPileDisplay();
            }

            if (deck.Count > 0)
            {
                UnoCard drawnCard = deck[0];
                deck.RemoveAt(0);
                hand.Add(drawnCard);

                int handIndex = playerHands.IndexOf(hand);
                if (handIndex >= 0 && handIndex < playerHandPanels.Count)
                {
                    CreateCardPictureBox(drawnCard, hand.Count - 1, playerHandPanels[handIndex], true);
                }
                else
                {
                    Console.WriteLine("Error: Invalid hand index.");
                }
            }
        }
        // Reshuffle function with logic to leave top discard card visible and shuffle only remaining cards
        private void ReshuffleDiscardPile()
        {
            if (discardPile.Count > 1)
            {
                UnoCard topCard = discardPile[discardPile.Count - 1];
                discardPile.RemoveAt(discardPile.Count - 1);
                deck.AddRange(discardPile);
                discardPile.Clear();
                discardPile.Add(topCard);
                ShuffleDeck();
            }
        }
        // Shufle randomization function
        private void ShuffleDeck()
        {
            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                UnoCard value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }
        // Starting hand logic
        private void DealStartingHand(List<UnoCard> hand, int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                DrawCard(hand);
            }
        }
        // Legal move logic
        private void PlayCard(UnoCard card, List<UnoCard> hand)
        {
            if (IsLegalMove(card, hand))
            {
                discardPile.Add(card);
                hand.Remove(card);
                UpdateDiscardPileDisplay();
                UpdatePlayerHandDisplay(hand);

                // Handle wild cards
                if (card.Color == "wild")
                {
                    currentColor = ChooseWildColor(hand); // Prompt player to choose color
                }
                // Win condition check on play
                ApplyCardEffects(card);
                if (hand.Count == 0)
                {
                    CheckWinCondition(hand);
                }
                else
                {
                    NextPlayer();
                }
            }
            else
            {
                MessageBox.Show("Illegal move.");
            }
        }
        // Shows last played card
        private void UpdateDiscardPileDisplay()
        {
            discardPilePanel.Controls.Clear();
            if (discardPile.Count > 0)
            {
                UnoCard topCard = discardPile[discardPile.Count - 1];
                CreateCardPictureBox(topCard, 0, discardPilePanel, true);
            }
        }
        // Shows card backs for the deck pile from path
        private void UpdateDeckPileDisplay()
        {
            deckPilePanel.Controls.Clear();
            if (deck.Count >= 0)
            {
                PictureBox deckImage = new PictureBox();
                deckImage.Size = new Size(100, 150);
                try
                {
                    string imagePath = Path.Combine("C:\\Users\\dj_dc\\OneDrive\\Desktop\\Programming Language 2\\uno_ColorAdd\\img", "card_back.png");
                    deckImage.Image = Image.FromFile(imagePath);
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Image file not found: card_back.png");
                }
                deckImage.SizeMode = PictureBoxSizeMode.StretchImage;
                deckPilePanel.Controls.Add(deckImage);
            }
        }
        // Create the display for hands
        private void UpdatePlayerHandDisplay(List<UnoCard> hand)
        {
            Panel panel = playerHandPanels[playerHands.IndexOf(hand)];
            panel.Controls.Clear();
            for (int i = 0; i < hand.Count; i++)
            {
                // Can modify here to display the backs of cards instead for an AI game
                CreateCardPictureBox(hand[i], i, panel, true);
            }
        }
        // Uses list of deck to generate cards as needed 
        private void CreateCardPictureBox(UnoCard card, int index, Panel panel, bool showFront)
        {
            PictureBox cardPictureBox = new PictureBox();
            cardPictureBox.Location = new Point(index * 110, 0);
            cardPictureBox.Size = new Size(100, 150);
            try
            {
                // Logic for card front or card back
                string imagePath;
                if (showFront)
                {
                    imagePath = Path.Combine("C:\\Users\\dj_dc\\OneDrive\\Desktop\\Programming Language 2\\uno_ColorAdd\\img", card.ImageName);
                }
                else
                {
                    imagePath = Path.Combine("C:\\Users\\dj_dc\\OneDrive\\Desktop\\Programming Language 2\\uno_ColorAdd\\img", "card_back.png");
                }
                cardPictureBox.Image = Image.FromFile(imagePath);
            }
            catch (System.IO.FileNotFoundException)
            {
                // Error message for cards not found
                MessageBox.Show($"Image file not found: {(showFront ? card.ImageName : "card_back.png")}");
            }
            // Card display and interaction settings
            cardPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardPictureBox.MouseEnter += CardPictureBox_MouseEnter;
            cardPictureBox.MouseLeave += CardPictureBox_MouseLeave;
            cardPictureBox.Tag = card;
            cardPictureBox.MouseDown += CardPictureBox_MouseDown;
            cardPictureBox.MouseMove += CardPictureBox_MouseMove;
            cardPictureBox.MouseUp += CardPictureBox_MouseUp;
            panel.Controls.Add(cardPictureBox);
        }
        // Logic to allow for dragging while left mouse button is pressed
        private void CardPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draggedCard = (PictureBox)sender;
                draggedCard.DoDragDrop(draggedCard.Image, DragDropEffects.Move);
            }
        }
        // Method for behavior while mouse is moving. May revisit
        private void CardPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
        }
        // Drop logic
        private void CardPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            draggedCard = null;
        }
        // Drag-Drop target logic 
        private void discardPilePanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        // drop resolution logic
        private void discardPilePanel_DragDrop(object sender, DragEventArgs e)
        {
            if (draggedCard != null)
            {
                UnoCard card = (UnoCard)draggedCard.Tag;
                List<UnoCard> hand = playerHands[playerHandPanels.IndexOf((FlowLayoutPanel)draggedCard.Parent)];
                PlayCard(card, hand);
            }
        }
        // Game start logic after initialization
        private void StartGame()
        {
            ShuffleDeck();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                DealStartingHand(playerHands[i], 7);
            }
            DrawCard(discardPile); // Draw the first discard card
            UpdateDiscardPileDisplay(); // Update the display *after* drawing the card
            UpdateCurrentPlayerLabel();
        }
        // Player turn direction logic
        private void NextPlayer()
        {
            if (reverseDirection)
            {
                currentPlayerIndex = (currentPlayerIndex - 1 + numberOfPlayers) % numberOfPlayers;
            }
            else
            {
                currentPlayerIndex = (currentPlayerIndex + 1) % numberOfPlayers;
            }
            UpdateCurrentPlayerLabel();
        }
        // Player indicator
        private void UpdateCurrentPlayerLabel()
        {
            currentPlayerLabel.Text = $"Player {currentPlayerIndex + 1}'s Turn";
        }
        //Logic section
        private bool unoCalled = false;
        private bool reverseDirection = false;
        private string currentColor = ""; // Track the current color after a wild card is played
        // Legal play verification bool
        private bool IsLegalMove(UnoCard card, List<UnoCard> hand)
        {
            if (discardPile.Count == 0) return true; // Allow 1st card down on setup

            UnoCard topDiscard = discardPile[discardPile.Count - 1];
            if (topDiscard == null) return false;
            // Wild card verification loop
            if (card.Color == "wild")
            {
                if (card.Value == "wilddraw4")
                {
                    // Verify the wilddraw4 can be played as long as hand doesn't contain matching color to current topDiscard
                    return !hand.Any(c => c.Color == (string.IsNullOrEmpty(currentColor) ? topDiscard.Color : currentColor) && c.Color != "wild");
                }
                else
                {
                    return true;
                }
            }

            return card.Color == (string.IsNullOrEmpty(currentColor) ? topDiscard.Color : currentColor) || card.Value == topDiscard.Value;
        }
        // Color choice ComboBox with legal color options based on colors in hand
        private string ChooseWildColor(List<UnoCard> hand)
        {
            List<string> availableColors = hand.Where(c => c.Color != "wild").Select(c => c.Color).Distinct().ToList();

            if (availableColors.Count == 0)
            {
                availableColors = new List<string>{"red","blue","green","yellow"}; // if hand only contains wild cards.
            }

            string chosenColor = "";
            Form colorSelectionForm = new Form();
            colorSelectionForm.Text = "Choose a Color";
            colorSelectionForm.Size = new Size(200, 150);
            colorSelectionForm.StartPosition = FormStartPosition.CenterParent;

            ComboBox colorComboBox = new ComboBox();
            colorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorComboBox.DataSource = availableColors;
            colorComboBox.Location = new Point(10, 10);
            colorSelectionForm.Controls.Add(colorComboBox);

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Location = new Point(10, 50);
            okButton.DialogResult = DialogResult.OK;
            colorSelectionForm.Controls.Add(okButton);

            // Updates color flag
            if (colorSelectionForm.ShowDialog() == DialogResult.OK)
            {
                chosenColor = colorComboBox.SelectedItem.ToString();
            }

            return chosenColor;
        }
        // Special effect switch logic. Added color reset to handle runtime errors I encountered
        private void ApplyCardEffects(UnoCard playedCard)
        {
            switch (playedCard.Value)
            {
                // Included the SkipNextPlayer() function here to allow for possible house rules
                case "draw2":
                    DrawTwoCards();
                    SkipNextPlayer();
                    currentColor = ""; // Reset currentColor
                    break;
                case "skip":
                    SkipNextPlayer();
                    currentColor = ""; // Reset currentColor
                    break;
                case "reverse":
                    reverseDirection = !reverseDirection;
                    currentColor = ""; // Reset currentColor
                    break;
                case "wilddraw4":
                    DrawFourCards();
                    SkipNextPlayer();
                    currentColor = ""; // Reset currentColor
                    break;
                case "wild":
                    //Color is set within playcard and choose wild color functions.
                    break;
            }
        }
        // Draw2 effect logic
        private void DrawTwoCards()
        {
            for (int i = 0; i < 2; i++)
            {
                DrawCard(playerHands[GetNextPlayerIndex()]);
            }
        }
        // Draw4 effect logic
        private void DrawFourCards()
        {
            for (int i = 0; i < 4; i++)
            {
                DrawCard(playerHands[GetNextPlayerIndex()]);
            }
        }
        // Skip effect logic
        private void SkipNextPlayer()
        {
            NextPlayer();
        }
        // Update/verify play direction
        private int GetNextPlayerIndex()
        {
            int nextPlayerIndex;
            if (reverseDirection)
            {
                nextPlayerIndex = (currentPlayerIndex - 1 + numberOfPlayers) % numberOfPlayers;
            }
            else
            {
                nextPlayerIndex = (currentPlayerIndex + 1) % numberOfPlayers;
            }
            return nextPlayerIndex;
        }
        // UNO check to end game. Needs more logic to challenge
        private void CheckWinCondition(List<UnoCard> hand)
        {
            if (unoCalled)
            {
                MessageBox.Show($"Player {currentPlayerIndex + 1} wins!");
                ResetGame(); // Add a method to reset the game
            }
            else
            {
                MessageBox.Show($"Player {currentPlayerIndex + 1} forgot to say UNO and draws 2 cards!");
                DrawCard(hand);
                DrawCard(hand);
                NextPlayer();
            }
        }
        // Reset the game board. Troubleshoot and maybe add button to activate
        private void ResetGame()
        {
            deck.Clear();
            discardPile.Clear();
            playerHands.Clear();
            playerHandPanels.ForEach(panel => panel.Controls.Clear());
            InitializeUnoDeck();
            StartGame();
            unoCalled = false;
        }
        // Run game
        public class UnoCard
        {
            public string Color { get; set; }
            public string Value { get; set; }
            public string ImageName { get; set; }
            public bool IsWild { get; set; }

            public UnoCard(string color, string value, string imageName, bool isWild)
            {
                Color = color;
                Value = value;
                ImageName = imageName;
                IsWild = isWild;
            }
        }
    }
}