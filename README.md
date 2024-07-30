# Hanabi
For this project, I aim to build an app to play the card game Hanabi. The first version will have just a pass-and-play mode of the game, but after the app is more solidified, experimenting with other modes of play would be the next goal. 

## My Outline
Coding Language: I plan to use C# with .NET Maui
1. Build the basic game in a command line environment to easily test functionality. The game will be a pass-and-play style of playing.
2. Convert to an app with a better UI for better testing and usability.
3. Experiment with a solo play mode with computers or an online play mode with different users not nearby. 


## General structure of UI and Code
### UI
- Show the back of your hand with certain cards labeled with the information that you have received
- Display other player's hands (Best in Landscape mode, but make it good for either)
- When the user selects a player, the player's hand will enlarge to fill the screen
- Display of public knowledge (stacks, discard, # of hint tokens, countdown to bomb explosion) 
### Coding
- Create a Card class with values of color(enum), number(int), knowColor(bool), and knowNumber(bool).
- The deck just needs to be a randomized stack of all of the possible cards. Then remove from the top to build hands for players and when a player draws a card.
- Each turn will have 3 options; play a card, discard a card, or give another player a hint.
- Create a Player class that has a hand of cards to keep track of who has what cards.
- Create a Discard class with a set for each color. Then you can display to the players, which cards have been discarded.
- Create a PlayArea class with an int for each color. When a card is successfully played in that color, the int will update to the new number. 
- The game loop will need to check when the deck runs out and alert the players that there is one round left in the game.
- At the end of the game, the score will need to be shown, which is the total of all of the stacks(or ints) in the PlayArea class.


#### My notes
- Computer players
  - If obvious discard, discard (number and/or color is not playable)
  - If obvious play, play (number has high chance, know number and color and that is what is needed, maybe if one specific card was pointed out recently)
  - If no hint option and none of the above, then discard oldest card or random with no info.

Hours worked on: 0hr
