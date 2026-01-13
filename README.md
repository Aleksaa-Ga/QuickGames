# QuickGames – C# Console Mini-Games

**QuickGames** is a collection of simple console-based games implemented in C#.  

Currently included game: **Hangman**.

---

## Overview

This project demonstrates:

- Object-oriented design with clear separation of responsibilities
- Input validation and user interaction in console applications
- Use of `List<T>`, `StringBuilder`, and string manipulation
- File I/O for dynamic word loading
- Game logic handled via loops, conditions, and methods

---

## Hangman – Current Features

- Random word selection from a file of example words
- Tracks guessed letters and displays the current state of the word
- Limits the number of mistakes allowed
- Informs the player about correct or incorrect guesses
- Prevents repeating previously guessed letters
 - **Hint system**: `NEW`
  - Limited number of hints per game
  - A hint reveals a letter at a chosen position
 - **Improved console readability**: `NEW`
  - Visual separators (`-----`, `*****`) between game sections
  - Clear messages guiding the player through each step

Example flow:

```
------------------------------
Welcome to Hangman!
Your task is to guess the word by entering letters, but be careful!
You can only make 8 mistakes.
------------------------------

------------------------------
Do you want to use a hint?
if so, type '?' mark when entering the letter
You have used 0 out of 3 hints.
------------------------------

Please enter a letter: a
Good job! The letter is in the word.
Guessed letters: A__A_
******************************

------------------------------
Do you want to use a hint?
if so, type '?' mark when entering the letter
You have used 0 out of 3 hints.
------------------------------

Please enter a letter: ?
Using a hint will reveal one letter.
You have used 1 out of 3 hints.
------------------------------

Choose the position of the letter you wish to reveal.
Enter a number between 1 and 5: 3
Guessed letters: A_RA_
******************************
...
```

---
## Project Updates

### Latest Update
  **Hints system added to Hangman**

The Hangman game has been extended with a hint mechanism:
- The player can use a limited number of hints
- Each hint reveals a letter at a chosen position
- Input is fully validated to prevent invalid or out-of-range values
- The current number of used and remaining hints is clearly displayed

### Console Improvements
- Visual separators added for better readability
- Clearer feedback messages for user actions
- Improved overall console flow and user experience

## Future Development

This project is actively maintained and will be expanded with:

- New quick console games, e.g., Tic-Tac-Toe
- Enhanced Hangman features:
  - ASCII art visualization of the hangman instead of only showing mistakes

---

## How to Run

1. Clone the repository: git clone https://github.com/Aleksaa-Ga/QuickGames.git
2. Open the solution in Visual Studio
3. Build and run the project
4. Follow the console instructions to play Hangman<br>
Words for Hangman are loaded from the file Data\exampleWordsHangmanWordGame.txt.
