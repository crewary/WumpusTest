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
    public partial class WinningForm : Form
    {

        ////Application.Run(new WinningForm(1, 2, 3));
        //throw that in the main program to test

        /*
         win = new WinningForm(trivia.getCoins(), arrows, turns);
         win.ShowDialog();
         this.Close();
         */         //i think you use this, dunno if it works
        
        private HighScore high;
        private String playerName = "";
        private int coins;
        private int arrows;
        private int turns;
        public WinningForm(int c, int a, int t)
        {
            InitializeComponent();
            high = new HighScore();
            int score = high.CalculateScore(coins, arrows, turns);
            coins = c;
            arrows = a;
            turns = t;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            playerName += nameBox.Text;
            int score = high.CalculateScore(coins, arrows, turns);
            high.UpdateHighScores(playerName, score, coins, arrows, turns);
            high.openHighScoreForm();
        }
    }
}
