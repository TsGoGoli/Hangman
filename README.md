# Hangman

Design an object oriented design for the game of Hangman.
In Hangman, the computer picks a random word for the player to guess. The player then
proceeds to guess the word by selecting letters from the alphabet, which get filled in, progressively
revealing the word. The player can only get so many letters wrong (a letter not found in the word) before
losing the game. An example run of this game could look like this:

## Primary Features

- The game picks a word at random from a list of words.
- The game�s state is displayed to the player, as shown above.
- The player can pick a letter. If they pick a letter they already chose, pick again.
- The game should update its state based on the letter the player picked.
- The game needs to detect a win for the player (all letters have been guessed).
- The game needs to detect a loss for the player (out of incorrect guesses).

### Advanced Features 

- Automatically populate list of words from a text file.
- Store statistics about each game played (Player name/surname, total games played, how many wins/losses)
- In case of exceptions being thrown during gameplay, log them to a separate file
- Add functionality to the application to display Highest scorer players (Calculated from the text file)

![run](https://github.com/user-attachments/assets/ad579bdb-3a24-40b2-805a-d4327899e296)
