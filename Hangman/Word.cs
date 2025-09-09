using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Hangman
{
    internal class Word
    {
        public List<char> correctGuesses = new List<char>();
        public List<char> incorrectGuesses = new List<char>();

        private string name;
        private string hidden;
        private int length;
        private int misses;

        public Word()
        {
            name= "sequence";
        }

        public Word(string word)
        {
            name = word;
            length = word.Length;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Hidden
        {
            get { return hidden; }
            set { hidden = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Misses
        {
            get { return misses; }
            set { misses += value; }
        }

        public void HideWord()
        {
            hidden = "";
            foreach (char letter in name)
            {
                if (correctGuesses.Contains(letter))
                {
                    hidden += letter;
                }
                else if (letter == ' ')
                {
                    hidden += " ";
                }
                else
                {
                    hidden += "_";
                }
            }
        }

        public void FailCheck()
        {
            string ascci = "   ____\n  |\n  |\n  |\n  |\n——--—";
            if (Misses == 0)
            {
                 ascci= "   ____\n  |\n  |\n  |\n  |\n——--—";
                Console.WriteLine(ascci);
            }
            else if (misses == 1)
            {
                ascci = ascci.Insert(11, "    |");
                //Console.WriteLine("  ____");
                //Console.WriteLine(" |    |");
                //Console.WriteLine(" |");
                //Console.WriteLine(" |");
                //Console.WriteLine(" |");
                //Console.WriteLine("———");
                Console.WriteLine(ascci);
            }
            else if (misses == 2)
            {
                ascci = ascci.Insert(21, "    O");
                //Console.WriteLine("  ____");
                //Console.WriteLine(" |    |");
                //Console.WriteLine(" |    O");
                //Console.WriteLine(" |");
                //Console.WriteLine(" |");
                //Console.WriteLine("———");
            }
                
            else if (misses == 3)
            {
                Console.WriteLine("  ____");
                Console.WriteLine(" |    |");
                Console.WriteLine(" |    O");
                Console.WriteLine(" |    |");
                Console.WriteLine(" |    |");
                Console.WriteLine("———");
            }
                
            else if (misses == 4)
            {
                Console.WriteLine("  ____");
                Console.WriteLine(" |    |");
                Console.WriteLine(" |    O");
                Console.WriteLine(" |  \\ |");
                Console.WriteLine(" |    |");
                Console.WriteLine("———");
            }
                
            else if (misses == 5)
            {
                Console.WriteLine("  ____");
                Console.WriteLine(" |    |");
                Console.WriteLine(" |    O");
                Console.WriteLine(" |  \\ | /");
                Console.WriteLine(" |    |");
                Console.WriteLine("———");
            }
               
            else if (misses == 6)
            {
                Console.WriteLine("  ____");
                Console.WriteLine(" |    |");
                Console.WriteLine(" |    O");
                Console.WriteLine(" |  \\ | /");
                Console.WriteLine(" |    |");
            }
        }
    }
}
