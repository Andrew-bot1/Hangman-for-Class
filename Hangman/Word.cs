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
        private string correctGuesses;
        private string name;
        private string hidden;
        private int length;
        private int misses;

        public Word()
        {
            name= "sequence";
        }
        
        public string CorrectGuesses
        {
            get { return correctGuesses; }
            set { correctGuesses = value; }
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
            if (correctGuesses != null)
            {
                foreach (char letter in name)
                {
                    foreach (char let in correctGuesses)
                    {
                        if (letter == let)
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
            }
            else
            {
                foreach (char letter in name)
                {
                    if (letter == ' ')
                    {
                        hidden += " ";
                    }
                    else
                    {
                        hidden += "_";
                    }
                }
            }
        }
    }
}
