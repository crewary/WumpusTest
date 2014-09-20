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
    public partial class HighScoresForm : Form
    {
        private HighScore _HighScore = new HighScore();
        public int numberOfHighScores = 10;     //number of scores to be saved
        private String[,] highScoreParts;       //rectangular array containing player scores

        public HighScoresForm()
        {
            InitializeComponent();
            this.RefreshScores();
        }

        //taken out because new scores shouldn't be created randomly and need to be updated in
        private void RefreshScores()
        {
            highScoreParts = _HighScore.ScoreComponents();
            WriteScores();
        }

        /// <summary>
        /// Progresses through rectangular array of Highscores and places corresponding columns of score components
        /// to the row of the players in the array into the display form
        /// -
        /// Every row (p) is one player's saved data
        /// Every column contains data
        /// i=0; highscore
        /// i=1; number of coins
        /// i=2; number of arrows
        /// i=3; number of turns
        /// i=4; Player name
        /// </summary>
        private void WriteScores()
        {
            for (int i = 0; i < 5; i++)
            {
                String textLine = "";
                for (int p = 0; p < numberOfHighScores; p++)
                {
                    textLine += highScoreParts[p, i] + "\n";
                }
                if (i == 4)
                {
                    NameBox.Text = textLine;
                }
                if (i == 1)
                {
                    CoinBox.Text = textLine;
                }
                if (i == 2)
                {
                    ArrowsBox.Text = textLine;
                }
                if (i == 3)
                {
                    TurnBox.Text = textLine;
                }
                if (i == 0)
                {
                    HighScoreBox.Text = textLine;
                }
            }
        }

        //Closes HighScoreDiplayForm
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
