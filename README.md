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

Example flow:

Welcome to Hangman! <br>
Your task is to guess the word by entering letters, but be careful!<br>
You can only make 8 mistakes.<br>
<br>
Please enter a letter:<br>
A<br>
Good job! The letter is in the word.<br>
Guessed letters: _A__A<br>
...<br>

---

## Future Development

This project is actively maintained and will be expanded with:

- New quick console games, e.g., Tic-Tac-Toe
- Enhanced Hangman features:
  - Optional hints for the player
  - ASCII art visualization of the hangman instead of only showing mistakes

---

## How to Run

1. Clone the repository: git clone https://github.com/Aleksaa-Ga/QuickGames.git
2. Open the solution in Visual Studio
3. Build and run the project
4. Follow the console instructions to play Hangman<br>
Words for Hangman are loaded from the file Data\exampleWordsHangmanWordGame.txt.
