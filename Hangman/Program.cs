using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    
    
    internal class Program
    {
        //method for updating correct guesses
        static void UpdateGuesses(Word myWord, char guess)
        {
            if (myWord.Name.Contains(guess))
            {
                if (myWord.CorrectGuesses != null)
                {
                    foreach (char letter in myWord.CorrectGuesses)
                    {
                        if (myWord.CorrectGuesses.Contains(guess))
                        {
                            Console.WriteLine("You already guessed that letter!");
                            return;
                        }
                        else
                        {
                            myWord.CorrectGuesses += guess;
                        }
                    }
                }
                else
                {
                    myWord.CorrectGuesses += guess;
                }
            }

            else
            {
                myWord.Misses += 1;
            }

            
        }
        //method for one word hangman
        static void OneWordHang()
        {
            Word myWord = new Word();
            
            //enter loop until user guesses word or runs out of tries
            while (true)
            {
                char guess;
                myWord.HideWord();
                Console.WriteLine($"{myWord.Hidden}\nEnter Guess:");
                guess = Convert.ToChar(Console.ReadLine());
                UpdateGuesses(myWord, guess);
                Console.WriteLine(myWord.CorrectGuesses);
                Console.WriteLine(myWord.Name);
                Console.WriteLine(guess);
                Console.WriteLine(myWord.Hidden);
            }

            Console.WriteLine($"Word is {myWord.Name}");
        }


        //method for array of words
        static void Main(string[] args)
        {
            //enter loop until user wants to exit
            while (true)
            {
                Console.WriteLine("Menu:\n1. One Word Hangman\n2. Array of Words Hangman\n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                //switch to call methods
                switch (choice)
                {
                    case 1:
                        OneWordHang();
                        break;
                    case 2:
                        //ArrayOfWordsHang();
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
