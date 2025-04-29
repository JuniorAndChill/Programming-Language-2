<img src="https://brewquets.com.au/cdn/shop/files/UnoCards_2000x.jpg?v=1686630700" height="150" alt="UNO Cards">

# C# UNO Game Project - Design Document

**Author:** Daniel Critchlow Jr

**Date:** February 11 2025

## Introduction

This document outlines the design and implementation plan for a C# implementation of the classic UNO card game. The project will be object-oriented and presented in a graphical user interface (GUI).  This document details the game's rules, object structure, game logic, and planned features.

## Table of Contents

*   [Game Rules](#game-rules)
*   [Game Design](#game-design)
*   [Object Model](#object-model)
*   [Game Logic](#game-logic)
*   [UI/UX Considerations](#uiux-considerations)
*   [Game Board Concept](#game-board-concept)
*   [Future Enhancements](#future-enhancements)
*   [Project To-Do List](#project-to-do-list)

## Game Rules <a name="game-rules"></a>

This project will implement the core rules of the original UNO game, featuring number cards and special action cards.  The game will support multiplayer (assumed 2-4 players).  Graphics will be low-tech, focusing on functionality over visual fidelity.

### Card Types

*   **Number Cards:** 0-9 (two of each 1-9 per color, one 0 per color)
*   **Special Cards:**
    *   Skip (2 per color)
    *   Reverse (2 per color)
    *   Draw Two (+2) (2 per color)
    *   Wild (4 total)
    *   Wild Draw Four (4 total)

### Card Effects

The following describes the effects of special cards when played:

*   **Skip:** The next player in the sequence misses their turn.
*   **Reverse:** The order of play reverses (clockwise to counter-clockwise or vice-versa).
*   **Draw Two:** The next player draws two cards and misses their turn.
*   **Wild:** The player who played the Wild card declares the next color to be matched. This card can be played regardless of matching colors in the player's hand.
*   **Wild Draw Four:** The player who played the Wild Draw Four card declares the next color to be matched. The next player draws four cards and misses their turn. This card can only be played if the player has no cards of the current color in their hand.

### Gameplay

1.  Players start with 7 cards.
2.  The top card of the deck is flipped to start the discard pile.
3.  Players take turns playing a card that matches the top card of the discard pile in color, number, or symbol.
4.  Wild cards can be played at any time.
5.  Players can draw a card from the deck if they have no playable cards.  They can optionally play the drawn card.
6.  The first player to empty their hand wins the round.

## Game Design <a name="game-design"></a>

The project will follow an object-oriented design, focusing on creating reusable and maintainable components.

## Object Model <a name="object-model"></a>

The core objects in the game will be:

### Card Class

*   **Attributes:**
    *   <font color="blue">`suit` (Enum: RED, YELLOW, BLUE, GREEN, WILD)</font> <font color="magenta">// Represents the card's color or if it's a wild card.</font>
    *   <font color="blue">`value` (Enum: ZERO, ONE, TWO, ..., NINE, SKIP, REVERSE, DRAW_TWO, WILD, WILD_DRAW_FOUR)</font> <font color="magenta">// Represents the card's number or special function.</font>
*   **Methods:**
    *   <font color="blue">`getSuit()`</font> <font color="magenta">// Returns the card's suit.</font>
    *   <font color="blue">`getValue()`</font> <font color="magenta">// Returns the card's value.</font>
    *   <font color="blue">`isPlayable(Card otherCard)`</font> <font color="magenta">// Returns `true` if this card can be played on `otherCard`. Handles color and value matching, as well as special card rules.</font>
    *   <font color="blue">`play(Game game, Player currentPlayer, Player nextPlayer)`</font> <font color="magenta">// Executes the card's effect (e.g., skip, reverse, draw two). This method encapsulates the logic for how each card affects the game state.</font>

### Deck Class

*   **Attributes:**
    *   <font color="blue">`cards` (List of `Card` objects)</font> <font color="magenta">// **COMPOSITION ("has-a"):** Stores the cards in the deck.</font>
*   **Methods:**
    *   <font color="blue">`shuffle()`</font> <font color="magenta">// Shuffles the deck.</font>
    *   <font color="blue">`drawCard()`</font> <font color="magenta">// Draws the top card from the deck and returns it.</font>
    *   <font color="blue">`isEmpty()`</font> <font color="magenta">// Checks if the deck is empty.</font>
    *   <font color="blue">`reset(discardPile)`</font> <font color="magenta">// Resets the deck using the discard pile (except the top card). This is called when the draw pile is empty</font>

### Player Class

*   **Attributes:**
    *   <font color="blue">`hand` (List of `Card` objects)</font> <font color="magenta">// **COMPOSITION ("has-a"):** The player's current hand of cards.</font>
    *   <font color="blue">`name` (String)</font> <font color="magenta">// The player's name.</font>
    *   <font color="blue">`isSkipped` (Boolean)</font> <font color="magenta">// Tracks if the player's turn is skipped due to a Skip or Draw Two card.</font>
    *   <font color="blue">`isUno` (Boolean)</font> <font color="magenta">// Tracks if the player has called UNO.</font>
*   **Methods:**
    *   <font color="blue">`playCard(Card card, Card discardPileTop)`</font> <font color="magenta">// Plays a card from the player's hand. Handles checking if the move is legal and updating the discard pile.</font>
    *   <font color="blue">`drawCard(Deck deck)`</font> <font color="magenta">// Draws a card from the deck and adds it to the player's hand.</font>
    *   <font color="blue">`hasPlayableCard(Card discardPileTop)`</font> <font color="magenta">// Checks if the player has a playable card in their hand, given the top card of the discard pile.</font>
    *   <font color="blue">`callUno()`</font> <font color="magenta">// Sets the Player's UNO state.</font>
    *   <font color="blue">`checkUno()`</font> <font color="magenta">// Returns the Player's UNO state.</font>

### Game Class

*   **Attributes:**
    *   <font color="blue">`deck` (`Deck` object)</font> <font color="magenta">// **COMPOSITION ("has-a"):** The game's deck of cards.</font>
    *   <font color="blue">`discardPile` (List of `Card` objects)</font> <font color="magenta">// **COMPOSITION ("has-a"):** The discard pile.</font>
    *   <font color="blue">`players` (List of `Player` objects)</font> <font color="magenta">// **COMPOSITION ("has-a"):** The list of players in the game.</font>
    *   <font color="blue">`currentPlayer` (`Player` object)</font> <font color="magenta">// **INSTANCE (specific player in current game):** The current player whose turn it is.</font>
    *   <font color="blue">`gameDirection` (Enum: CLOCKWISE, COUNTER_CLOCKWISE)</font> <font color="magenta">// The current direction of play.</font>
*   **Methods:**
    *   <font color="blue">`initializeGame(numPlayers)`</font> <font color="magenta">// **CONSTRUCTOR (Should place in constructor):** Initializes the game, creating the deck, players, and dealing initial hands.</font>
    *   <font color="blue">`startGame()`</font> <font color="magenta">// Starts the main game loop.</font>
    *   <font color="blue">`playTurn()`</font> <font color="magenta">// Handles a single player's turn, including drawing, playing, and handling special card effects.</font>
    *   <font color="blue">`isGameOver()`</font> <font color="magenta">// Checks if the game is over (a player has emptied their hand).</font>
    *   <font color="blue">`isValidMove(Card card, Card discardPileTop)`</font> <font color="magenta">// Checks if a move is valid according to the game rules.</font>
    *   <font color="blue">`handleSpecialCard(Card card, Player currentPlayer, Player nextPlayer)`</font> <font color="magenta">// **POLYMORPHISM (Can be if special cards overwrite `card()` class):** Handles the effects of special cards.</font>
    *   <font color="blue">`determineNextPlayer()`</font> <font color="magenta">// Determines the next player based on the game direction and any skipped players.</font>
    *   <font color="blue">`getWinner()`</font> <font color="magenta">// Returns the winning player (or null if the game is not over).</font>


## Game Logic <a name="game-logic"></a>

The game logic will be implemented within the `Game` class, using the methods defined above. The `playTurn()` method will orchestrate the flow of a single turn, including drawing cards, playing cards, handling special card effects, and checking for a win.  The `isValidMove()` method will be crucial for enforcing the game rules.

## UI/UX Considerations <a name="uiux-considerations"></a>

The GUI will be designed to be simple and intuitive.  It will display the players' hands (only the current player's hand will be fully visible), the discard pile, and the current player.  Buttons will be provided for playing cards, drawing cards, and calling (TBD) "UNO."  The UI will communicate game state and relevant information to the player. Color blind symbols added to top corner of cards to indicate colors discreetly. 

##  Game Board Concept <a name="game-board"></a>

[(Game Board Concept)](../UNOGameBoard.md)
![](UNO_layout_draft.png)

## Future Enhancements <a name="future-enhancements"></a>

*   **Scoring:** Implement scoring across multiple rounds (traditional scoring is 1st player to 500 points).
*   **UNO Checking:** Add penalties for failing to call "UNO."
*   **Challenge System:** Allow players to challenge the legality of a Wild Draw Four play.
*   **Two-Player Specific Rules:** Implement special rules for a two-player game (e.g., Reverse acts as Skip).
*   **Draw Card Stacking:** Allow players to stack Draw Two or Wild Draw Four cards.
*   **Card-Back Customization:** Allow players to choose card-back themes for the deck.

## Project To-Do List <a name="project-to-do-list"></a>

*   [ ] Implement `Card` class.
*   [ ] Implement `Deck` class.
*   [ ] Implement `Player` class.
*   [ ] Implement `Game` class.
*   [ ] Design and implement the GUI.
*   [ ] Implement game logic and rules enforcement.
*   [ ] Implement future enhancements (as time permits).
*   [ ] Test the game thoroughly.
*   [ ] Document the code.