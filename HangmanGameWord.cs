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

        public bool CheckLetter(char letter) //checking if a word contains this letter, could also be solved with LINQ

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
    }
}
