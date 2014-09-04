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
    public partial class Form2 : Form
    {
        private HighScore _HighScore = new HighScore();

        public Form2()
        {
            InitializeComponent();
            //_HighScore = new HighScore();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int arrows = Int32.Parse(tboxArrows.Text);
            int coins = Int32.Parse(tboxCoins.Text);
            int turns = Int32.Parse(tboxTurns.Text);
            String name = tboxName.Text;

            //String str = ""+arrows+coins+turns+score;
            String str = "" + _HighScore.CalculateScore(coins, arrows, turns);
            returnScoreBox.Text = str;

            /*
            int fivetest = int.Parse(tboxScore.Text);
            Console.WriteLine(int.Parse(tboxArrows.Text));
            Console.WriteLine(fivetest + " string parted to integer");
            //Console.WriteLine(str);
            //returnScoreBox.Text = "Hello";
            */
        }


        private void UpdateHighScores_Click(object sender, EventArgs e)
        {
            int arrows = Int32.Parse(tboxArrows.Text);
            int coins = Int32.Parse(tboxCoins.Text);
            int turns = Int32.Parse(tboxTurns.Text);
            /*
            String str = "" + _HighScore.CalculateScore(coins, arrows, turns);
            returnScoreBox.Text = str;
            */
            int score = Int32.Parse(returnScoreBox.Text);
            String name = tboxName.Text;
            _HighScore.UpdateHighScores(name, score, coins, arrows, turns);
        }

        /*
        private void button2_Click_1(object sender, EventArgs e)
        {
            String[,] str = _HighScore.ScoreComponents(); 
            String text = _HighScore.formatHighScores();
            Console.WriteLine(text);
            ScoresTextBox.Text = text;
            label1.Text = text;
        }
         */

        private void button3_Click(object sender, EventArgs e)
        {
            String[,] str2 = _HighScore.ScoreComponents();
        }

        private void TestNewFormButton_Click(object sender, EventArgs e)
        {
            //HighScoreForm hs = new HighScoreForm();
            //hs.ShowDialog();
            _HighScore.openHighScoreForm();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ScoresTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}