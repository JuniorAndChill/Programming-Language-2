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
        private bool isPlayDirectionClockwise = true;
        private PictureBox draggedCard = null; // initial drag state
        private List<PictureBox> playerArrowIndicators;
        private Image arrowUpImage;
        private Image arrowDownImage;
        private Label activeColorLabel;
        public Form1()
        {
            InitializeComponent();
            InitializePanels();
            InitializeButtons();
            InitializeLabels();
            InitializeUnoDeck();
            InitializeZoomedCardPictureBox();
            InitializeCardControls();
            InitializeTurnArrows();
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
        private void InitializeTurnArrows()
        {
            // Define image paths
            string filePath1 = Path.Combine(Application.StartupPath);
            string arrowUpPath = Path.Combine(filePath1, "arrowUp.png");
            string arrowDownPath = Path.Combine(filePath1, "arrowDown.png");

            // Pre-load images
            try
            {
                arrowUpImage = Image.FromFile(arrowUpPath);
                arrowDownImage = Image.FromFile(arrowDownPath);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Error loading arrow image: {ex.Message}\nPlease ensure '{ex.FileName}' exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Can't continue without arrow images
            }
            catch (Exception ex) // Catch other potential loading errors
            {
                MessageBox.Show($"Generic error loading arrow image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            playerArrowIndicators = new List<PictureBox>();

            // Define Arrow Positions (relative to player areas)
            // Arrow for Player 0 (Bottom-Left Panel Area)
            Point arrow0Pos = new Point(playerHandPanels[0].Left + playerHandPanels[0].Width / 2 - 25, playerHandPanels[0].Top - 100); // Above center of panel 0
            PictureBox arrow0 = CreateArrowPictureBox(arrow0Pos);
            playerArrowIndicators.Add(arrow0);

            // Arrow for Player 1 (Bottom-Right Panel Area)
            Point arrow1Pos = new Point(playerHandPanels[1].Left + playerHandPanels[1].Width / 2 - 25, playerHandPanels[1].Top - 100); // Above center of panel 1
            PictureBox arrow1 = CreateArrowPictureBox(arrow1Pos);
            playerArrowIndicators.Add(arrow1);

            // Arrow for Player 2 (Top-Left Panel Area)
            Point arrow2Pos = new Point(playerHandPanels[2].Left + playerHandPanels[2].Width / 2 - 25, playerHandPanels[2].Bottom + 10); // Below center of panel 2
            PictureBox arrow2 = CreateArrowPictureBox(arrow2Pos);
            playerArrowIndicators.Add(arrow2);

            // Arrow for Player 3 (Top-Right Panel Area)
            Point arrow3Pos = new Point(playerHandPanels[3].Left + playerHandPanels[3].Width / 2 - 25, playerHandPanels[3].Bottom + 10); // Below center of panel 3
            PictureBox arrow3 = CreateArrowPictureBox(arrow3Pos);
            playerArrowIndicators.Add(arrow3);


            // Add all created arrows to the form's controls
            foreach (var arrow in playerArrowIndicators)
            {
                this.Controls.Add(arrow);
                arrow.BringToFront(); // Ensure arrows are drawn on top
            }

            // Initial turn indicator is set after StartGame() calls NextPlayer indirectly or directly.
        }
        private PictureBox CreateArrowPictureBox(Point location)
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(50, 50); // Standard size
            pb.Location = location;     // Set position
            pb.SizeMode = PictureBoxSizeMode.StretchImage; // Scale image to fit
            pb.BackColor = Color.Transparent; // Makes background see-through
            pb.Visible = false;         // Start hidden
            return pb;
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
            currentPlayerLabel.BringToFront();
            activeColorLabel = new Label();
            activeColorLabel.Name = "activeColorLabel"; // Good practice to name controls
            activeColorLabel.AutoSize = true;         // Let the label size itself
            activeColorLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            activeColorLabel.Text = "Color: -"; // Initial default text
            activeColorLabel.ForeColor = Color.White; // Text color
            activeColorLabel.BackColor = Color.DarkGray; // Default background
            activeColorLabel.Padding = new Padding(3); // Add some internal padding

            // Position it to the right of the discard pile panel
            // Align top edges, with a small gap
            int labelX = discardPilePanel.Right + 10; // 10 pixels to the right
            int labelY = discardPilePanel.Top;         // Align with the top of the discard pile

            activeColorLabel.Location = new Point(labelX, labelY);

            this.Controls.Add(activeColorLabel); // Add it to the form
            activeColorLabel.BringToFront();      // Ensure it's visible
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
        }
        // Custom UNO! message box and functions
        private void UnoButton_Click(object sender, EventArgs e)
        {
            if (playerHands[currentPlayerIndex].Count == 1) // Only valid if player HAS one card
            {
                unoCalled = true;
                // Simple confirmation message
                MessageBox.Show($"Player {currentPlayerIndex + 1} declared UNO!", "UNO!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You can only call UNO when you have one card left!", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Deck creation and concatnation
        private void InitializeUnoDeck()
        {
            string filePath1 = Path.Combine(Application.StartupPath);
            string[] colors = { "red", "yellow", "green", "blue", "wild" };
            string[] values = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "skip", "reverse", "draw2", "wild", "wilddraw4" };

            foreach (string color in colors)
            {
                // Only process wild cards for "wild" color.
                if (color == "wild")
                {
                    foreach (string value in new[] { "wild", "wilddraw4" })
                    {
                        string imageName = Path.Combine(filePath1, $"{color}_{value}.png");
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
                        string imageName = Path.Combine(filePath1, $"{color}_{value}.png");
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
            // Check if it's the current player's turn and the card is in their hand
            if (playerHands.IndexOf(hand) != currentPlayerIndex)
            {
                MessageBox.Show("It's not your turn!", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!hand.Contains(card))
            {
                MessageBox.Show("Card not found in your hand!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Should not happen with drag/drop but good check
            }
            if (IsLegalMove(card, hand))
            {
                string chosenColorForWild = card.Color; // Store original color in case it's wild (was a longtime issue)
                // Handle wild cards needing color choice *before* moving to discard
                if (card.IsWild)
                {
                    chosenColorForWild = ChooseWildColor(hand); // Prompt player to choose color
                    if (string.IsNullOrEmpty(chosenColorForWild))
                    {
                        MessageBox.Show("You must choose a color for the wild card.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Abort play if no color chosen
                    }
                    currentColor = chosenColorForWild; // Set the game's current color
                                                       // Optionally update the card appearance in discard? Or rely on currentColor flag.
                }
                else
                {
                    currentColor = ""; // Reset current color if a non-wild card is played
                }
                discardPile.Add(card);
                hand.Remove(card);
                // Reset UNO status after playing a card
                if (hand.Count > 1)
                {
                    unoCalled = false;
                }
                UpdateDiscardPileDisplay();
                UpdatePlayerHandDisplay(hand); // Update the hand *after* removing card
                UpdateDeckPileDisplay(); // Update deck count visual (optional, sometimes too many updates causes lagged gameplay)
                // Apply effects *after* card is successfully played and displays updated
                ApplyCardEffects(card);
                // Check win condition *after* applying effects
                if (hand.Count == 0)
                {
                    CheckWinCondition(hand);
                    // If game ended/reset by CheckWinCondition, stop further processing in this turn
                    if (hand.Count == 0 && discardPile.Count == 0) 
                        return; // A bit crude check for reset might be needed
                }
                // Move to the next player only if it was a NUMBER card (another issues spot)
                // ApplyCardEffects handles turn progression for ALL action cards (Skip, Rev, D2, Wild, WD4).
                bool isActionCard = card.Value == "skip" || card.Value == "reverse" || card.Value == "draw2" || card.IsWild; // IsWild covers wild and wilddraw4
                if (!isActionCard)
                {
                    // Only call NextPlayer for standard number cards
                    NextPlayer();
                }
            }
            else
            {
                MessageBox.Show("Illegal move.", "Invalid Play", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                UpdateActiveColorLabel();
            }
        }
        // Shows card backs for the deck pile from path
        private void UpdateDeckPileDisplay()
        {
            string filePath1 = Path.Combine(Application.StartupPath);
            deckPilePanel.Controls.Clear();
            if (deck.Count >= 0)
            {
                PictureBox deckImage = new PictureBox();
                deckImage.Size = new Size(100, 150);
                try
                {
                    string imagePath = Path.Combine(filePath1, "card_back.png");
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
                // Can modify here to display the backs of cards instead for an AI game (maybe for another time)
                CreateCardPictureBox(hand[i], i, panel, true);
            }
        }
        public void UpdateTurnIndicator()
        {
            // Check state - Ensure list exists and count matches players.
            // We also need at least the default arrow image loaded.
            bool listOk = playerArrowIndicators != null;
            bool defaultImageOk = arrowUpImage != null; // Check if the default image is loaded
            bool countOk = listOk && playerArrowIndicators.Count == numberOfPlayers;

            // Basic checks before proceeding
            if (!listOk || !defaultImageOk || !countOk)
            {
                return;
            }

            // Hide all player arrow indicators
            foreach (var arrow in playerArrowIndicators)
            {
                arrow.Visible = false;
            }

            // Check if the current player index is valid
            bool indexValid = currentPlayerIndex >= 0 && currentPlayerIndex < numberOfPlayers;
            if (indexValid)
            {
                // Select the correct arrow PictureBox for the current player
                PictureBox currentArrow = playerArrowIndicators[currentPlayerIndex];

                if (currentPlayerIndex == 0 || currentPlayerIndex == 1) // Set image if it's missing
                {
                    currentArrow.Image = arrowDownImage; // Use a default "active turn" image
                }
                else
                {
                    currentArrow.Image = arrowUpImage;
                }
                // Make ONLY the current player's arrow visible
                currentArrow.Visible = true;
                currentArrow.BringToFront(); // Ensure it's not hidden behind other controls
            }            
        }
        // Uses list of deck to generate cards as needed
        private void CreateCardPictureBox(UnoCard card, int index, Panel panel, bool showFront)
        {
            string filePath1 = Path.Combine(Application.StartupPath);
            PictureBox cardPictureBox = new PictureBox();
            cardPictureBox.Location = new Point(index * 110, 0);
            cardPictureBox.Size = new Size(100, 150);
            try
            {
                // Logic for card front or card back
                string imagePath;
                if (showFront)
                {
                    imagePath = Path.Combine(filePath1, card.ImageName);
                }
                else
                {
                    imagePath = Path.Combine(filePath1, "card_back.png");
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

            UpdateDeckPileDisplay();
            UpdateDiscardPileDisplay();
            UpdateCurrentPlayerLabel();
            UpdateTurnIndicator();
        }
        // Player turn direction logic
        private void NextPlayer()
        {
            // Use the unified direction variable (another long troublshooting spot)
            if (isPlayDirectionClockwise) // Should be true initially
            {
                // Original order: 0 -> 1 -> 2 -> 3 -> 0
                currentPlayerIndex = (currentPlayerIndex + 1) % numberOfPlayers;
            }
            else // Counter-clockwise (Reversed)
            {
                // Reversed order: 0 -> 3 -> 2 -> 1 -> 0
                currentPlayerIndex = (currentPlayerIndex - 1 + numberOfPlayers) % numberOfPlayers;
            }
            UpdateCurrentPlayerLabel();
            UpdateTurnIndicator(); // Updates the arrow indicator position/visibility
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
            // Must be current player's turn
            if (playerHands.IndexOf(hand) != currentPlayerIndex) return false;
            if (discardPile.Count == 0) return true; // Should not happen after StartGame deals first card
            UnoCard topDiscard = discardPile.Last();
            if (topDiscard == null) return false; // Should not happen
            // Check against the active color (if a wild was played previously)
            string activeColor = string.IsNullOrEmpty(currentColor) ? topDiscard.Color : currentColor;

            // Wild cards are always playable (but WildDraw4 has restrictions)
            if (card.IsWild)
            {
                if (card.Value == "wilddraw4")
                {
                    // Check if the player has any card matching the *active* color
                    // Player CANNOT play WildDraw4 if they HAVE a card of the active color.
                    bool hasMatchingColorCard = hand.Any(c => !c.IsWild && c.Color == activeColor);
                    return !hasMatchingColorCard;
                }
                else // Regular wild card
                {
                    return true;
                }
            }
            // Regular card: check color or value match
            return card.Color == activeColor || card.Value == topDiscard.Value;
        }
        // Color choice ComboBox with legal color options based on colors in hand
        private string ChooseWildColor(List<UnoCard> hand) // 'hand' parameter needed for logic
        {
            // Always allow choosing any color
            List<string> availableColors = new List<string> { "Red", "Blue", "Green", "Yellow" };

            string chosenColor = "";
            using (Form colorSelectionForm = new Form()) // Use using statement for proper disposal
            {
                colorSelectionForm.Text = "Choose a Color";
                colorSelectionForm.Size = new Size(200, 150);
                colorSelectionForm.StartPosition = FormStartPosition.CenterParent;
                colorSelectionForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                colorSelectionForm.ControlBox = false; // Prevent closing without choosing

                ComboBox colorComboBox = new ComboBox();
                colorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                colorComboBox.DataSource = availableColors; // Show standard colors
                colorComboBox.Location = new Point(10, 10);
                colorComboBox.Size = new Size(150, 25);
                colorSelectionForm.Controls.Add(colorComboBox);

                Button okButton = new Button();
                okButton.Text = "OK";
                okButton.Location = new Point(colorSelectionForm.ClientSize.Width / 2 - okButton.Width / 2, 50);
                okButton.DialogResult = DialogResult.OK; // Set DialogResult (troubleshoot tool)
                colorSelectionForm.AcceptButton = okButton; // Allow Enter key
                colorSelectionForm.Controls.Add(okButton);

                if (colorSelectionForm.ShowDialog(this) == DialogResult.OK) // Show as modal dialog relative to main form
                {
                    if (colorComboBox.SelectedItem != null)
                    {
                        chosenColor = colorComboBox.SelectedItem.ToString().ToLower(); // Store as lowercase
                    }
                    else
                    {
                        // Handle case where somehow OK is pressed with no selection (shouldn't happen with DropDownList)
                        chosenColor = availableColors[0].ToLower(); // Default to first color
                    }
                }
                else
                {
                    // Handle case where user closes the dialog without pressing OK (if ControlBox was true)
                    // Or if ShowDialog returns something else. Force a choice or default.
                    // Since ControlBox is false, this part might not be reachable unless ShowDialog fails.
                    chosenColor = availableColors[0].ToLower(); // Default if dialog is closed unexpectedly
                }
            } // using statement ensures form is disposed

            return chosenColor;
        }
        private void UpdateActiveColorLabel()
        {
            // Safety check in case this is called before initialization
            if (activeColorLabel == null) return;

            string displayColorText = "-"; // Default text part (e.g., for empty discard)
            Color displayBackColor = Color.DarkGray; // Default background color

            // Determine the active color:
            // Check if a wild color was chosen (`currentColor` variable)
            if (!string.IsNullOrEmpty(currentColor))
            {
                displayColorText = currentColor;
            }
            // If no wild color is active, check the top card of the discard pile
            else if (discardPile.Count > 0)
            {
                UnoCard topCard = discardPile.Last();
                // If the top card is not wild, use its color
                if (!topCard.IsWild)
                {
                    displayColorText = topCard.Color;
                }
                // If the top card IS wild, but no color chosen (shouldn't happen after first turn), keep default "-"
            }

            // Update the Label's Text
            activeColorLabel.Text = $"Color: {displayColorText.ToUpper()}";

            // Update the Label's Background Color (optional, but good visual cue)
            switch (displayColorText.ToLower()) // Use ToLower for case-insensitive comparison
            {
                case "red": displayBackColor = Color.Red; break;
                case "blue": displayBackColor = Color.Blue; break;
                case "green": displayBackColor = Color.Green; break;
                case "yellow": displayBackColor = Color.Yellow; break;
                default: displayBackColor = Color.DarkGray; break; // Default for "-" or "wild"
            }
            activeColorLabel.BackColor = displayBackColor;

            // Adjust text color for better contrast on certain backgrounds
            if (displayBackColor == Color.Yellow || displayBackColor == Color.LightGray)
            {
                activeColorLabel.ForeColor = Color.Black;
            }
            else
            {
                activeColorLabel.ForeColor = Color.White;
            }
        }
        // Special effect switch logic. Added color reset to handle runtime errors I encountered
        private void ApplyCardEffects(UnoCard playedCard)
        {
            int playerWhoShouldPlayNext; // To store the index calculated by the effect

            switch (playedCard.Value)
            {
                case "draw2":
                    DrawTwoCards(); // Effect first
                                    // Then calculate turn progression (skip one player)
                    playerWhoShouldPlayNext = GetPlayerIndexAfterSkip();
                    currentPlayerIndex = playerWhoShouldPlayNext; // Set the new current player
                    UpdateCurrentPlayerLabel();
                    UpdateTurnIndicator();
                    break;

                case "skip":
                    // Calculate turn progression (skip one player)
                    playerWhoShouldPlayNext = GetPlayerIndexAfterSkip();
                    currentPlayerIndex = playerWhoShouldPlayNext; // Set the new current player
                    UpdateCurrentPlayerLabel();
                    UpdateTurnIndicator();
                    break;

                case "reverse":
                    if (numberOfPlayers == 2)
                    {
                        // Acts like Skip in 2-player game
                        playerWhoShouldPlayNext = GetPlayerIndexAfterSkip();
                        currentPlayerIndex = playerWhoShouldPlayNext; // Set the new current player
                    }
                    else
                    {
                        // Reverse direction first
                        isPlayDirectionClockwise = !isPlayDirectionClockwise;
                        // Turn goes to the next player in the NEW direction
                        currentPlayerIndex = GetNextPlayerIndex(); // Get index 1 step in new direction
                    }
                    // Update UI for the NEW current player and direction
                    UpdateCurrentPlayerLabel();
                    UpdateTurnIndicator(); // Updates arrow image (direction) and position
                    break;

                case "wilddraw4":
                    DrawFourCards(); // Effect first
                                     // Then calculate turn progression (skip one player)
                    playerWhoShouldPlayNext = GetPlayerIndexAfterSkip();
                    currentPlayerIndex = playerWhoShouldPlayNext; // Set the new current player
                    UpdateCurrentPlayerLabel();
                    UpdateTurnIndicator();
                    break;

                case "wild":
                    // Color is chosen in PlayCard. Turn progresses normally.
                    // Call NextPlayer here because PlayCard won't do it for action cards.
                    NextPlayer();
                    break;

                default: // Number card
                         // No effect, turn progression handled by PlayCard.
                         // Ensure current color is reset.
                    currentColor = "";
                    break;
            }

            // Reset current color ONLY if the played card was NOT wild (of any type).
            if (!playedCard.IsWild) // Check the IsWild property of the card itself
            {
                if (!string.IsNullOrEmpty(currentColor)) // Only update if color *was* set
                {
                    currentColor = "";
                    // Update the discard pile background now that the forced color is cleared
                    UpdateDiscardPileDisplay();
                    Debug.WriteLine($"ApplyCardEffects: Reset currentColor because {playedCard} is not Wild."); // Debug
                }
            }
            else
            {
                Debug.WriteLine($"ApplyCardEffects: Did NOT reset currentColor because {playedCard} is Wild."); // Debug
            }
        }
        // Draw card logic
        private void DrawTwoCards()
        {
            int targetPlayer = GetNextPlayerIndex(); // Target is the next player
            DrawCard(playerHands[targetPlayer]);
            DrawCard(playerHands[targetPlayer]);
            UpdatePlayerHandDisplay(playerHands[targetPlayer]); // Update display after drawing
        }
        private void DrawFourCards()
        {
            int targetPlayer = GetNextPlayerIndex(); // Target is the next player
            DrawCard(playerHands[targetPlayer]);
            DrawCard(playerHands[targetPlayer]);
            DrawCard(playerHands[targetPlayer]);
            DrawCard(playerHands[targetPlayer]);
            UpdatePlayerHandDisplay(playerHands[targetPlayer]); // Update display after drawing
        }
        // Needed seperate skip player logic
        private int GetPlayerIndexAfterSkip()
        {
            // First, find the index of the player who would normally be next
            int normallyNextPlayerIndex = GetNextPlayerIndex();

            // Then, find the index of the player after *that* one, using the current direction
            if (isPlayDirectionClockwise)
            {
                return (normallyNextPlayerIndex + 1) % numberOfPlayers;
            }
            else // Counter-clockwise
            {
                return (normallyNextPlayerIndex - 1 + numberOfPlayers) % numberOfPlayers;
            }
        }
        // Update/verify play direction
        private int GetNextPlayerIndex()
        {
            // Use the unified direction variable
            if (isPlayDirectionClockwise)
            {
                return (currentPlayerIndex + 1) % numberOfPlayers;
            }
            else // Counter-clockwise
            {
                return (currentPlayerIndex - 1 + numberOfPlayers) % numberOfPlayers;
            }
        }
        // UNO check to end game. Needs more logic to challenge
        private void CheckWinCondition(List<UnoCard> hand)
        {
            if (hand.Count == 0) // Hand is empty, potential win
            {
                if (unoCalled) // Did they call Uno?
                {
                    // Player successfully emptied their hand. Did they call UNO?
                    int winnerPlayerIndex = currentPlayerIndex; // Capture winner index *before* anything else
                    string winnerMessage = $"Player {winnerPlayerIndex + 1} declared UNO and wins!";
                    MessageBox.Show(winnerMessage, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecordScores(winnerPlayerIndex); // Update winner index
                    ResetGame(); // Resets currentPlayerIndex to 0 AFTER scoring is done
                }
                else
                    {
                        // Penalty for not calling UNO!
                        MessageBox.Show($"Player {currentPlayerIndex + 1} emptied their hand but forgot to call UNO! Penalty: Draw 2 cards.", "UNO Penalty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DrawCard(hand); // Draw penalty into the (now empty) hand
                        DrawCard(hand);
                        UpdatePlayerHandDisplay(hand); // Show the penalty cards
                                                       // Since they drew cards, the game continues, move to next player
                        NextPlayer();
                    }
                }
            // If hand is not empty, reset unoCalled status for the *next* turn.
            if (hand.Count != 0)
            {
                unoCalled = false;
            }
        }
        // Game scoring method
        private int GetCardScore(UnoCard card)
        {
            // Number cards (0-9): Check if the Value is an integer
            if (int.TryParse(card.Value, out int numberValue))
            {
                return numberValue; // Return face value
            }

            // Action and Wild cards
            switch (card.Value.ToLower()) // Use ToLower() for case-insensitivity
            {
                case "draw2":
                case "reverse":
                case "skip":
                    return 20; // Action cards are 20 points

                case "wild":
                case "wilddraw4":
                    return 50; // Wild cards are 50 points

                default:
                    System.Diagnostics.Debug.WriteLine($"Warning: Unknown card value '{card.Value}' encountered during scoring.");
                    return 0; // Should not happen with standard cards
            }
        }
        // Save scores method
        private void RecordScores(int actualWinnerIndex)
        {
            // Simple Score Calculation & Output
            try
            {
                int winnerIndex = actualWinnerIndex; // Use the passed-in index
                int totalScoreForWinner = 0;
                // Calculate score based on cards left in opponents' hands
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    // Skip the winner's hand
                    if (i == winnerIndex) continue;

                    // Sum scores from this opponent's hand
                    int opponentHandScore = 0;
                    if (playerHands != null && i < playerHands.Count && playerHands[i] != null)
                    {
                        foreach (UnoCard card in playerHands[i])
                        {
                            opponentHandScore += GetCardScore(card);
                        }
                    }
                    totalScoreForWinner += opponentHandScore;
                }
                // Prepare the output lines (P1 - Score, P2 - Score, etc.)
                List<string> scoreOutputLines = new List<string>();
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    // Winner gets the calculated score, others get 0 for this round
                    int score = (i == winnerIndex) ? totalScoreForWinner : 0;
                    scoreOutputLines.Add($"P{i + 1} - {score}");
                }
                // Define the output file path
                string fileName = "scores.txt";
                string filePath = Path.Combine(Application.StartupPath, fileName);
                File.WriteAllLines(filePath, scoreOutputLines);
                // Notify user
                MessageBox.Show($"Scores saved to '{fileName}' in application folder.\n\nWinner (Player {winnerIndex + 1}) scored {totalScoreForWinner} points this round!",
                                "Game Over - Scores Saved",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (IOException ioEx) // Catch specific IO errors
            {
                MessageBox.Show($"Failed to save scores to '{Path.Combine(Application.StartupPath, "scores.txt")}'.\n\nError: {ioEx.Message}\n\nCheck file permissions.",
                                "File Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex) // Catch any other unexpected errors
            {
                MessageBox.Show($"An unexpected error occurred while saving scores.\n\nError: {ex.Message}",
                                "Scoring Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        // Reset the game board. Troubleshoot and maybe add button to activate
        private void ResetGame()
        {
            // Remove Old Arrow Controls
            if (playerArrowIndicators != null)
            {
                foreach (var arrow in playerArrowIndicators)
                {
                    if (arrow != null)
                    {
                        this.Controls.Remove(arrow);
                        arrow.Dispose();
                    }
                }
                playerArrowIndicators.Clear();
                playerArrowIndicators = null;
            }
            deck.Clear();
            discardPile.Clear();
            foreach (var hand in playerHands)
            {
                hand.Clear();
            }
            foreach (var panel in playerHandPanels)
            {
                panel.Controls.Clear();
            }
            discardPilePanel.Controls.Clear();
            discardPilePanel.BackColor = Color.LightGray;
            deckPilePanel.Controls.Clear();
            deckPilePanel.BackColor = Color.Gray;

            // Reset state variables
            currentPlayerIndex = 0;
            isPlayDirectionClockwise = true;
            unoCalled = false;
            currentColor = "";
            draggedCard = null;

            InitializeUnoDeck(); // Recreate the deck list
            InitializeTurnArrows(); // Create new PictureBoxes, add to new list, add to Controls

            // Temporarily disable the draw button to prevent accidental click
            bool drawButtonOriginalState = false;
            if (drawButton != null) // Check if drawButton has been initialized
            {
                drawButtonOriginalState = drawButton.Enabled;
                drawButton.Enabled = false;
            }

            StartGame(); // This now correctly calls UpdateTurnIndicator, UpdateDeckPileDisplay, etc.
                         // Game is set for Player 1 (index 0) to start.

            // Show the modal MessageBox
            MessageBox.Show("Game Reset.", "New Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Re-enable the draw button
            if (drawButton != null)
            {
                drawButton.Enabled = drawButtonOriginalState;
            }

            // Explicitly set focus to the form or a non-interactive panel.
            // This helps prevent an "Enter" key press for the MessageBox
            // from also triggering a focused button on the form.
            if (this.CanFocus)
            {
                this.Focus();
            }
        }
        // Run game
        public class UnoCard
        {
            public string Color { get; set; }
            public string Value { get; set; }
            public string ImageName { get; set; } // Stores the full path now
            public bool IsWild { get; set; }
            public UnoCard(string color, string value, string imageName, bool isWild)
            {
                Color = color;
                Value = value;
                ImageName = imageName;
                IsWild = isWild;
            }
            // Override ToString for debugging
            public override string ToString()
            {
                return $"{Color} {Value}";
            }
        }
    }
}