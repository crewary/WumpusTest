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
    public partial class HighScores : Form
    {
        private HighScore _HighScore = new HighScore();
        public int numberOfHighScores = 10;
        private String[,] highScoreParts;

        public HighScores()
        {
            InitializeComponent();
            this.RefreshScores();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.RefreshScores();
        }

        private void RefreshScores()
        {
            highScoreParts = _HighScore.ScoreComponents();
            this.WriteScores();
        }

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
