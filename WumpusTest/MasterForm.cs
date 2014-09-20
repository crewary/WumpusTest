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
    public partial class MasterForm : Form
    {
        //private MapAndPlayer map;
        private Cave cave;
        private HighScore high;
        private Trivia trivia;
        public int caveNumberFromMasterForm = 0;

        public MasterForm()
        {
            InitializeComponent();

            //map = new MapAndPlayer();
            cave = new Cave();
            high = new HighScore();
            trivia = new Trivia();

            button1.Hide();     //options for picking cave number
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            BackButton.Hide();
            room.Hide();
            ConstructorButton.Hide();
            HelpText.Hide();
            readBox.Text = "Let's play Hunt The Wumpus!";

            HelpText.Text = "Hunt The Wumpus is a map-based game where you need to seek out the wumpus and kill him. Along the way you will pick up coins and be allowed to answer trivia in order to obtain arrows to kill the Wumpus.";

        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }

        private void room_TextChanged(object sender, EventArgs e)
        {

        }

        //for testing
        private void ConstructorButton_Click(object sender, EventArgs e)
        {
            /*
            map = new MapAndPlayer();
            cave = new Cave();
            high = new HighScore();
            trivia = new Trivia();
             */ //I put these in the constructor
            Random gen = new Random();
            int initialRoom = gen.Next(30) + 1;
            String roomNumber = "" + initialRoom;
            room.Text = roomNumber;

        }

        private void readBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showHighScores_Click(object sender, EventArgs e)
        {
            high.openHighScoreForm();
        }

        //prompts player to pick a room/go back (start game button)
        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(150);
            readBox.Text = "Pick a room 1-5, or Back to go to the Home Screen";
            startGameBox.Hide();
            highScoresButton.Hide();
            HelpButtonMain.Hide();
            ExitButton.Hide();
            BackButton.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";

            
            //here's where we should probably close the form and start a new game depending on button clicked
        }

        private void readBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            caveNumberFromMasterForm = 1;
            this.Close();
        }

        //returns cave number picked to open game form with respective cave
        public int getCaveFromMasterForm()
        {
            return caveNumberFromMasterForm;
        }

        //brings up help text and allows player to go back
        private void HelpButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(150);
            startGameBox.Hide();
            highScoresButton.Hide();
            HelpButtonMain.Hide();
            ExitButton.Hide();
            BackButton.Show();
            readBox.Hide();
            HelpText.Show();
        }

        //brings player back to start prompt
        private void BackButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(150);
            startGameBox.Show();
            highScoresButton.Show();
            HelpButtonMain.Show();
            ExitButton.Show();
            BackButton.Hide();
            HelpText.Hide();
            readBox.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
        }

        //this is not self explanatory
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //below are cave options to be clicked          //option 1 is above
        private void button2_Click(object sender, EventArgs e)
        {
            caveNumberFromMasterForm = 2;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caveNumberFromMasterForm = 3;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            caveNumberFromMasterForm = 4;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            caveNumberFromMasterForm = 5;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
