using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickGames
{
    internal class HangmanGameWord
    {
        private readonly string wordToGuess;
        private string guessedLetters = "";
        private int hintsUsed = 0;
        public int HintsUsed { get { return hintsUsed; } }
        private const int maxHints = 3;
        public int MaxHints { get { return maxHints; } }

        public HangmanGameWord(string wordToGuess)
        {
            this.wordToGuess = wordToGuess.ToUpper();
            guessedLetters = new string('_', wordToGuess.Length);
        }
        public string GetWordToGuess() // returning the word to guess
        {
            return wordToGuess;
        }

        public string GetGuessedLetters() // returning word with the guessed letters
        {
            return guessedLetters;
        }

        public bool IsWordGuessed() //checking if the word is guessed
        {
            return wordToGuess.Equals(guessedLetters);
        }

        public bool CheckLetter(char letter) //checking if a word contains this letter
        {
            if (wordToGuess.Contains(letter))
            {
                StringBuilder sb = new StringBuilder(guessedLetters);

                for(int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == letter)
                    {
                        sb[i] = letter;
                        guessedLetters = sb.ToString(); // update guessed word
                    }
                }
                return true;
            }
            return false;
        }
        public void UseHint() // using a hint to reveal a letter
        {
            hintsUsed++;
            Console.WriteLine("Using a hint will reveal one letter.\n" +
                $"You have used {hintsUsed} out of {maxHints} hints.");
            Console.WriteLine(new string('-', 30) + "\n");

            Console.Write("Choose the position of the letter you wish to reveal.\n" +
                "Enter a number between 1 and " + wordToGuess.Length + ": ");
            int input = GetIntInput(Console.ReadLine());

            while (input < 1 || input > wordToGuess.Length) // validating input
            {
                Console.Write("Invalid position. Please enter a number between 1 and " + wordToGuess.Length + ": ");
                input = GetIntInput(Console.ReadLine());
            }

            StringBuilder sb = new StringBuilder(guessedLetters); // revealing the letter at the chosen position
            sb[input - 1] = wordToGuess[input - 1];
            guessedLetters = sb.ToString();
            Console.WriteLine("Guessed letters: " + guessedLetters);
            Console.WriteLine(new string('*', 30) + "\n");

        }

        int GetIntInput(string number) // validating integer input
        {
            int value;

            while(!int.TryParse(number, out value))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
                number = Console.ReadLine();
            }
            return value;
        }

        
    }
}
