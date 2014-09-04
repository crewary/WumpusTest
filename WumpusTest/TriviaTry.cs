using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WumpusTest2010
{
    public class TriviaTry
    {
        public TriviaTry()
        {
        }

        private String[] clues = null;

        /// <summary>
        /// This method will choose a random clue from the text file of Trivia clues
        /// </summary>
        /// <returns></returns> return a Trivia clue in String format
        public String getRandomClue()
        {
            if (clues == null)
            {
                loadClues();
            }
            var r = new Random();
            int randClue = r.Next(0, clues.Length);
            return clues[randClue];
        }

        /// <summary>
        /// Reads String clues from text file and then puts them into a String array
        /// </summary>
        private void loadClues()
        {
            clues = System.IO.File.ReadAllLines("TriviaClues.txt");
        }


        public static int numberWeAreOn = 2; //start at 2
        public String[] getQuestionsArray()
        {
            String[] questions = System.IO.File.ReadAllLines("Trivia.txt");
            return questions;
        }
        public String getQuestion() //start at question 1
        {
            String question = this.getQuestionsArray()[(numberWeAreOn - 1) * 4];
            return question;
        }
        public String[] getAnswers() //spot 0 is true, 1 and 2 false
        {
            String[] answers = new String[3];
            for (int p = 1; p < 4; p++)
            {

                answers[p - 1] = this.getQuestionsArray()[(numberWeAreOn - 1) * 4 + p];

            }
            return answers;
        }

        public static int coins = 0;
        public void addCoins(int numberOfCoinsToAdd)
        {
            coins += numberOfCoinsToAdd;
        }
        public int getCoins()
        {
            return coins;
        }

        public void resetNumberWeAreOn()
        {
            if (numberWeAreOn >= 20)
            {
                numberWeAreOn = 2;
            }
        }

        public void subtractOneFromNumberWeAreOn()
        {
            numberWeAreOn--;
        }

        public bool oneQuestions()
        {
            TriviaForm trivForm = new TriviaForm(1);
            trivForm.ShowDialog();
            if (trivForm.getWasPass())
            {
                Console.WriteLine("Was A Pass");
            }
            else
            {
                Console.WriteLine("Was A Fail");
            }
            //Console.WriteLine("Hello");
            return trivForm.getWasPass();
        }

        public bool threeQuestions()
        {
            TriviaForm trivForm = new TriviaForm(3);
            trivForm.ShowDialog();
            if (trivForm.getWasPass())
            {
                Console.WriteLine("Was A Pass");
            }
            else
            {
                Console.WriteLine("Was A Fail");
            }
            //Console.WriteLine("Hello");
            return trivForm.getWasPass();
        }

        public bool fiveQuestions()
        {
            TriviaForm trivForm = new TriviaForm(5);
            trivForm.ShowDialog();
            if (trivForm.getWasPass())
            {
                Console.WriteLine("Was A Pass");
            }
            else
            {
                Console.WriteLine("Was A Fail");
            }
            //Console.WriteLine("Hello");
            return trivForm.getWasPass();
        }

        public void gotASetOfQuestionsAndAnswers()
        {
            numberWeAreOn++;
        }


    }
}
