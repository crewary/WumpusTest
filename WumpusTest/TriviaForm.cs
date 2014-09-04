using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WumpusTest2010
{
    public partial class TriviaForm : Form
    {
        public int questionsToAnswer;
        public bool wasPass;
        public TriviaTry trivia;
        public int fails = 0;
        public int correct = 0;
        public int correctNumber;

        public TriviaForm(int numberOfQuestions) //3 or 5
        {
            InitializeComponent();
            trivia = new TriviaTry();
            //subtract one from counter on trivia
            trivia.subtractOneFromNumberWeAreOn();
            trivia.resetNumberWeAreOn();

            questionsToAnswer = numberOfQuestions;
            updateTriviaScore();
            oneQuestion();
        }

        public void updateTriviaScore()
        {
            correctBox.Text = "Number Correct: " + correct + "    Number Wrong: " + fails;
        }

        public void shouldClose()
        {
            if (questionsToAnswer == 1)
            {
                if (correct == 1)
                {
                    closeWin();
                }
                if (fails == 1)
                {
                    closeFail();
                }

            }
            if (questionsToAnswer == 3)
            {
                if (correct == 2)
                {
                    closeWin();
                }
                if (fails == 2)
                {
                    closeFail();
                }
                
            }
            if (questionsToAnswer == 5)
            {
                if (correct == 3)
                {
                    closeWin();
                }
                if (fails == 3)
                {
                    closeFail();
                }

            }
            
        }

        public void closeWin()
        {
            wasPass = true;
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~THIS IS WHERE YOU PUT GRAPHICS FOR WINNING TRIVIA~~~~~~~~
            System.Threading.Thread.Sleep(250);
            this.Close();
        }
        public void closeFail()
        {
            wasPass = false;
            System.Threading.Thread.Sleep(250);
            this.Close();
        }
        public bool getWasPass()
        {
            return wasPass;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int 0-2; the correct answer</returns>
        public void oneQuestion()
        {
            String[] answers = trivia.getAnswers();
            Random gen = new Random();
            String[] newAnswers = new String[3];
            int correctAnswer = gen.Next(3); //0,1,2
            correctNumber = correctAnswer;
            if(correctAnswer==0)
            {
                newAnswers[0]=answers[0];
                newAnswers[1]=answers[1];
                newAnswers[2]=answers[2];
            }
            if(correctAnswer==1)
            {
                newAnswers[0]=answers[1];
                newAnswers[1]=answers[0];
                newAnswers[2]=answers[2];
            }
            if(correctAnswer==2)
            {
                newAnswers[0]=answers[1];
                newAnswers[1]=answers[2];
                newAnswers[2]=answers[0];
            }

            String strOne = trivia.getQuestion() + "\n";

            String str = "a) " + newAnswers[0] + "\n";
            str += "b) " + newAnswers[1] + "\n";
            str += "c) " + newAnswers[2] + "\n";
            questionBox.Text = str;
            questionOneBox.Text = strOne;
            trivia.gotASetOfQuestionsAndAnswers();
            //return correctAnswer;
        }

        /*
        public int getLastNumberRight()
        {
            return lastNumberRight;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (correctNumber == 0)
            {
                correct++;
            }
            else
            {
                fails++;
            }
            updateTriviaScore();
            shouldClose();
            oneQuestion();
            trivia.addCoins(-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (correctNumber == 1)
            {
                correct++;
            }
            else
            {
                fails++;
            }
            updateTriviaScore();
            shouldClose();
            oneQuestion();
            trivia.addCoins(-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (correctNumber == 2)
            {
                correct++;
            }
            else
            {
                fails++;
            }
            updateTriviaScore();
            shouldClose();
            oneQuestion();
            trivia.addCoins(-1);
        }
    }
}
