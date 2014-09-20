using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//DOESNT WORK... USE TriviaTry instead
namespace WumpusTest2010
{
    public class Trivia
    {
        String[] questions = new String[25];
        public Trivia()
        {
            questions = this.fillInTrivia();
        }


        public String[] fillInTrivia()
        {
            /*using (StreamReader sr = new StreamReader("TriviaQuestion.txt"))
            {
                int i = 0;
                while (sr.Peek() >= 0)
                {
                    questions[i] = sr.ReadLine();
                    i++;
                }
            }*/
            return questions;
        }
        Random random = new Random();
        
        void Shuffle()
        {
            for (int i = 0; i < questions.Length - 1; i++)
            {
                int j = random.Next(i, questions.Length);
                string temp = questions[j];
                questions[j] = questions[i];
                questions[i] = temp;
            }
        }

        public bool encounterWumpus()
        {
            Shuffle();
            int numRight = 0;
            for (int i = 0; i < 5; i++)
            {
                string[] qAPair = questions[i].Split(';');
                Console.WriteLine(qAPair[0] + "\n");
                string answer = Console.ReadLine();
                if (answer.Equals(qAPair[1], StringComparison.InvariantCultureIgnoreCase))
                    numRight++;
            }
            return (numRight >= 3);
        }
        bool escapePit()
        {
            Shuffle();
            int numRight = 0;
            for (int i = 0; i < 3; i++)
            {
                string[] qAPair = questions[i].Split(';');
                Console.WriteLine(qAPair[0] + "\n");
                string answer = Console.ReadLine();
                if (answer.Equals(qAPair[1], StringComparison.InvariantCultureIgnoreCase))
                    numRight++;
            }
            return (numRight >= 2);
        }
        bool purchaseArrow()
        {
            Shuffle();
            int numRight = 0;
            for (int i = 0; i < 3; i++)
            {
                string[] qAPair = questions[i].Split(';');
                Console.WriteLine(qAPair[0] + "\n");
                string answer = Console.ReadLine();
                if (answer.Equals(qAPair[1], StringComparison.InvariantCultureIgnoreCase))
                    numRight++;
            }
            return (numRight >= 2);
        }
        bool purchaseSecret()
        {
            Shuffle();
            int numRight = 0;
            for (int i = 0; i < 3; i++)
            {
                string[] qAPair = questions[i].Split(';');
                Console.WriteLine(qAPair[0] + "\n");
                string answer = Console.ReadLine();
                if (answer.Equals(qAPair[1], StringComparison.InvariantCultureIgnoreCase))
                    numRight++;
            }
            return (numRight >= 2);
        }

    }
}
