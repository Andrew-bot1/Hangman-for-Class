
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
        
        static void Game(int gameType)
        {
            Word myWord = new Word();
            if (gameType == 2)
            {
                string[] wordArray = { "hangman", "program", "apple", "animal", "house", "computer", "c sharp", "house", "table", "dog", "cat", "hippo", "letter", "bread", "soup" };
                Random rand = new Random();
                int index = rand.Next(wordArray.Length);
                myWord = new Word(wordArray[index]);
            }
            
            //enter loop until user guesses word or runs out of tries
            while (true)
            {
                
                myWord.Ascci();
                myWord.HideWord();

                while (true)
                {
                    if (myWord.Hidden == myWord.Name)
                    {
                        Console.WriteLine($"You win! The word was {myWord.Name}.");
                        return;
                    }
                    else if (myWord.Misses == 7)
                    {
                        Console.WriteLine($"You Lose! The word was {myWord.Name}.");
                        return;
                    }
                    Console.WriteLine($"{myWord.Hidden}\nEnter Guess:");
                    string guess = Console.ReadLine().ToLower();
                    if (guess.Length != 1)
                    {
                        Console.WriteLine("Please enter a single letter.");
                    }

                    else if (myWord.correctGuesses.Contains(Convert.ToChar(guess)) || myWord.incorrectGuesses.Contains(Convert.ToChar(guess)))
                    {
                        Console.WriteLine("You already guessed that letter. Try again.");
                    }
                    else if (Char.IsLetter(Convert.ToChar(guess)))
                    {
                        myWord.UpdateGuesses(myWord, Convert.ToChar(guess));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a letter.");
                    }
                }
                    
            }
        }
        

        static void Main(string[] args)
        {
            //enter loop until user wants to exit
            while (true)
            {
                Console.WriteLine("Menu:\n1. Guess My Word\n2. Guess Random Word\n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                //switch to call methods
                switch (choice)
                {
                    case 1:
                        Game(1);
                        break;
                    case 2:
                        Game(2);
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
