<img src="https://brewquets.com.au/cdn/shop/files/UnoCards_2000x.jpg?v=1686630700" height="150" alt="UNO Cards">


# C Sharp final project #
# Daniel Critchlow Jr #

## Game Choice ##

- Original UNO game

## Game Design Deliverables ##

- The project will be object-oriented and presented in a GUI
- Design these parts 1st;
	- Objects
	- Methods
	- Attributes
- UNO game will be the original version featuring number cards and special cards
- Assume it's multiplayer
- The game will feature graphics which can be low-tech


## UNO components (Objects) ##

- **Deck size 108 cards**: 25 each suit, 8 wild
- **Suits (Colors)**: Red, Yellow, Blue, Green
- **Number cards**: 0-9 (2x 1-9, 1x set of 0s)
- **Special cards**: Skip, Reverse, Draw 2, Wild card, Wild Draw Four


### Special Card Effects (Methods) ###

- **Skip (2x each color)**: 
	- From Hand: Next player in sequence misses a turn
	- 1st Discard: Player to dealer's left misses a turn

- **Reverse (2x each color)**: 
	- From Hand: Order of play switches directions *clockwise to countclockwise or vice versa*
	- 1st Discard: Dealer plays 1st; play proceeds counterclockwise

- **Draw Two (+2) (2x each color)**:
	-From Hand: Next player in sequence draws two cards and misses a turn
	-1st Discard: Player to dealer's left draws two cards and misses a turn

- **Wild (4x)**:
	- From Hand: Player declares the next color to be matched 
		*May be used on any turn even if the player has any card of matching color*
	- 1st Discard: Player to dealer's left declares the 1st color to be matched & takes the 1st
	turn

- **Wild Draw Four (4x)**:
	- From Hand: Player declares the next color to be matched next player in sequence draws four
	cards and misses a turn. May be legally played if the player has no cards of the current color
	-1st Discard: Card is returned to the deck, then a new card is laid down into the discard pile 
		*Deck may be reshuffled 1st if needed*


### Player turn options ###

- Play one card matching the discard in color, number, or symbol
- Play a Wild card, or a Wild Draw Four card if allowed to 
	- Wild Draw Four can only be played if no matching color cards are in hand. Wild is always 
	legal and matching number/symbol can be present for Wild Draw Four play
		*Can add logic to challenge legal play...probably too difficult*
	- After Wild card play, current player MUST declare color
- Draw the top card from the deck, and optionally play it if possible
	- can only play drawn card but not hand cards
	- If draw deck runs out, top discard is set aside and rest is shuffled to create draw deck
- Call UNO
- Check UNO
	- Check and call UNO logic can be omitted to reduce difficulty of design


## Game Logic (Methods) ##

- Board initializer
- showBoard (board during active game state)
- ~~Player select (How many people are playing 1-4)~~
- Deck initial shuffle
- Deck gamestate shuffle
- initHand (7 card initial draw)
- initDiscard (start game) (top of deck flipped to start discard pile and game)
	- Check to make sure not Wild Draw Four, check isReverse, if Wild card was played
- Player hand (shows hand to owner but not others)
- Player/Game Win check
- gamePhase
	- Draw, check UNO, Play card, check Special, resolve effects, pass turn
- isLegal check (Checks if player made a legal play)
	- Checks list of various legal plays; 
		- *color match, card type match, no UNO state after last card, etc.*
- showDeck Pile (face down)
- showDiscard Pile (face up)
- isEmpty (checks if deck is empty)
- isUNO (checks if player is in UNO state)
- playerUNO (allows player to call UNO state)
	- dependent on isLegal and isUNO methods
- ColorSelect (allows player to chose color)
	- dependent on isLegal
- normalDraw
	- May need a check in what player phase is active; if draw is during Play card phase, end turn
- specialDraw
- turnOrder
- isReverse
- isSkip


## Game Logic Considerations ##

- Can set up the game to be multiple rounds with scoring (need to add scoring logic beyond simple game)
	- *Alternatively can set game to 1st one out wins*
- Can add **UNO** checking with penalties
- ~~- Can allow special logic for 2 player game; Reverse == Skip~~
- Draw card stacking; Allow players to stack draw cards to avoid drawing cards


## Project To-Do List ##

- [x] Figure out the outline 
- [ ] Figure out the Objects
- [ ] Figure out the Methods
- [ ] Figure out the Logic
- [X] Figure out the layout &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--->&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[(Game Board Concept)](../UNOGameBoard.md)
- [ ] Figure out UI_UX gaps
- [ ] Figure out the dependencies
- [ ] Figure out the code structure/naming convention
- [ ] Test app
- [ ] Verify deliverables

