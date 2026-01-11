using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickGames
{
    internal class HangmanGameManager
    {
        private readonly HangmanGameWord word;
        int mistakes = 0;
        int maxMistakes = 8;
        List<char> checkedLetters = new List<char>();


        public HangmanGameManager()
        {
            string randomWord = RandomWordSelector();
            word = new HangmanGameWord(randomWord);
            // word = new HangmanGameWord("teesst"); // for testing purposes
        }

        string RandomWordSelector() // selecting a random word from the file
        {
            List<string> words = LoadWordsFromFile();

            if (words?.Any() == true)
            {
                Random random = new Random();
                int index = random.Next(words.Count);
                return words[index];
            }
            else
            {
                return "DEFAULT"; // default word if file is empty or not found
            }
        }
        List<string> LoadWordsFromFile() // loading words from the file to a list
        {
            string content = "";

            try
            {
                if (!File.Exists(@"Data\exampleWordsHangmanWordGame.txt"))
                {
                    Console.WriteLine("The specified file does not exist.");
                    return new List<string>();
                }

                using (var sr = new StreamReader(@"Data\exampleWordsHangmanWordGame.txt"))
                {
                    content = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }
            return new List<string>(content.Split(';', StringSplitOptions.RemoveEmptyEntries));
        }
        public void StartHangmanGame() // starting the game
        {

            Console.WriteLine("Welcome to Hangman!\n" +
                "Your task is to guess the word by entering letters, but be careful!\n" +
                $"You can only make {maxMistakes} mistakes.");

            while(mistakes < maxMistakes && !word.IsWordGuessed()) // while mistakes are less than max mistakes and the word is not guessed
            {
                char letter = AskForLetter();

                if (word.CheckLetter(letter))
                {
                    Console.WriteLine("Good job! The letter is in the word.");
                }
                else
                {
                    mistakes++;
                    Console.WriteLine($"Sorry, the letter is not in the word.\n" +
                        $"You have {maxMistakes - mistakes} mistakes left.");
                }
                Console.WriteLine("Guessed letters: " + word.GetGuessedLetters());
            }

            if(word.IsWordGuessed()) // end of the game, win or lose?
            {
                Console.WriteLine("Congratulations! You've guessed the word: " + word.GetWordToGuess());
            }
            else
            {
                Console.WriteLine("Game over! You've used all your mistakes. The word was: " + word.GetWordToGuess());
            }
        }

        char AskForLetter()
        {
            string input;

            do
            {
                Console.WriteLine("Please enter a letter:");
                input = Console.ReadLine();

                if (input == null || input.Length != 1)
                {
                    Console.WriteLine("Please enter exactly one letter.");
                    continue;
                }

                char letter = char.ToUpper(input[0]); //assigning a character to a variable

                if (!char.IsLetter(letter))
                {
                    Console.WriteLine("Please enter a valid letter.");
                    continue;
                }

                if (checkedLetters.Contains(letter))
                {
                    Console.WriteLine("This letter has already been checked.");
                    continue;
                }

                checkedLetters.Add(letter); // adding to the list of verified characters + returning
                return letter;

            } while(true);
        }

    }
}
