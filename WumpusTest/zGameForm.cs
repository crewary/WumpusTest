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
    public partial class zGameForm : Form
    {
        private MapAndPlayer map;
        private HighScore high;
        private TriviaTry trivia;
        private int initialRoom;
        private bool hasCoins = false;
        private bool reached = false;

        public int score = 0;
        public int arrows = 3;
        public int turns = 0;
       

        
        public zGameForm(int whichCave)
        {
            InitializeComponent();
            inputBox.Text = whichCave.ToString();
            map = new MapAndPlayer(whichCave);
            high = new HighScore();
            trivia = new TriviaTry();
            pictureBox3.Hide();
           
            //LabelBox.Text = "Enter Player Name below and hit button to start";
            inputBox.Hide();
            //this.updateScoreTracker();
            //this.startPlayer();
            option1.Show();
            option2.Show();
            option3.Show();
            initialRoom = map.getRoom();
            String roomNum = "" + initialRoom;
            room.Text = roomNum;
            updateButtons(initialRoom);
            updateScoreTracker();
        }

        /*public void startPlayer()
        {
            Random gen = new Random();
            int startRoom = gen.Next(30) + 1;
            Console.WriteLine(startRoom);
            map.setRoom(startRoom);

        }*/

        public void updateScoreTracker()
        {
            if (arrows < 1)
            {
                if (!dialogue.Text.Equals("You win."))
                {
                    dialogue.Text = "You lose."; // help
                }
            }
            score = high.CalculateScore(trivia.getCoins(), arrows, turns);
            ScoreTracker.Text = "Score: " + score + "   Coins: " + trivia.getCoins() + "   Arrows: " + arrows + "   Turns: " + turns;
        }

        private void room_TextChanged(object sender, EventArgs e)
        {

        }

        public void updateButtons(int currentRoom)
        {
            if (trivia.getCoins() == 100)
            {
                reached = true;
            }
            if (arrows == 0)
            {
                if (!dialogue.Text.Equals("You win."))
                {
                    dialogue.Text = "You lose."; // help
                }
            }
            if (trivia.getCoins() > 0)
            {
                hasCoins = true;
            }
            if (hasCoins && trivia.getCoins() == 0)
            {
                if (!dialogue.Text.Equals("You win."))
                {
                    dialogue.Text = "You lose."; // help
                }
            }
            int roomIn = map.getRoom();
            if (!dialogue.Text.Equals("You lose.") && !dialogue.Text.Equals("You win."))
            {
                dialogue.Text = map._Cave.getWarning(roomIn);
            }
            if (map._Cave.wumpusInRoom(currentRoom))
            {
                if (trivia.fiveQuestions())
                {
                    map._Cave.moveWumpus(currentRoom);
                    pictureBox3.Show();
                }
                else
                {
                    if (!dialogue.Text.Equals("You win."))
                    {
                        dialogue.Text = "You lose."; // help me here
                    }
                }
            }
            /*if(map._Cave.pitInRoom(currentRoom)) {
                TriviaTry trivia = new TriviaTry();
                if(trivia.threeQuestions()) {
                    map.setRoom(initialRoom);
                    room.Text = "" + initialRoom;
                    //updateButtons(initialRoom);
                }
                else
                {
                    dialogue.Text = "You lose.";
                }
            }
            if(map._Cave.batsInRoom(currentRoom)) {
                map._Cave.moveBats(currentRoom);
                map.setRandomRoom();
            }*/
            String numTurns = "" + turns;
            int[] possibleSwitch = map._Cave.possibleRooms(currentRoom);

            int possibleLength = 0;
            for (int i = 0; i < possibleSwitch.Length; i++)
            {
                if (possibleSwitch[i] != -1)
                {
                    possibleLength++;
                }
            }
            int[] possible = new int[possibleLength];
            for (int i = 0; i < possibleLength; i++)
            {
                possible[i] = possibleSwitch[i];
            }

            if (possible.Length == 1)
            {
                option1.Show();
                int firstOption = possible[0];
                String optionOne = "" + firstOption;
                option1.Text = optionOne;
                shoot1.Show();
                shoot1.Text = "Shoot into " + firstOption;
                option2.Hide();
                shoot2.Hide();
                option3.Hide();
                shoot3.Hide();
            }
            else if (possible.Length == 2)
            {
                option1.Show();
                int firstOption = possible[0];
                String optionOne = "" + firstOption;
                option1.Text = optionOne;
                shoot1.Show();
                shoot1.Text = "Shoot into " + firstOption;
                option2.Show();
                int secondOption = possible[1];
                String optionTwo = "" + secondOption;
                option2.Text = optionTwo;
                shoot2.Show();
                shoot2.Text = "Shoot into " + secondOption;
                option3.Hide();
                shoot3.Hide();
            }
            else
            {
                option1.Show();
                int firstOption = possible[0];
                String optionOne = "" + firstOption;
                option1.Text = optionOne;
                shoot1.Show();
                shoot1.Text = "Shoot into " + firstOption;
                option2.Show();
                int secondOption = possible[1];
                String optionTwo = "" + secondOption;
                option2.Text = optionTwo;
                shoot2.Show();
                shoot2.Text = "Shoot into " + secondOption;
                option3.Show();
                int thirdOption = possible[2];
                String optionThree = "" + thirdOption;
                option3.Text = optionThree;
                shoot3.Show();
                shoot3.Text = "Shoot into " + thirdOption;
            }
        }//the length is always 3... just make it so if the option is -1 we hide //done

        public void updateCoins()
        {
            if (!reached && trivia.getCoins() < 100)
            {
                trivia.addCoins(1);
            }
        }

        public void checkHazards(int currentRoom)
        {
            if (map._Cave.pitInRoom(currentRoom))
            {
                if (trivia.threeQuestions())
                {
                    map.setRoom(initialRoom);
                    room.Text = "" + initialRoom;
                    //updateButtons(initialRoom);
                }
                else
                {
                    if (!dialogue.Text.Equals("You win."))
                    {
                        dialogue.Text = "You lose."; // help
                    }
                }
            }
            if (map._Cave.batsInRoom(currentRoom))
            {
                map._Cave.moveBats(currentRoom);
                map.setRandomRoom();
                int newRoom = map.getRoom();
                room.Text = "" + newRoom;
            }
        }

        private void option1_Click(object sender, EventArgs e)
        {
            int newRoom = Int16.Parse(option1.Text);
            if (map.movePlayer(newRoom))
            {
                turns++;
                int realRoom = map.getRoom();
                room.Text = "" + realRoom;
                checkHazards(realRoom);
                int trueRoom = map.getRoom();
                updateButtons(trueRoom);
                updateCoins();
                updateScoreTracker();
                ClueBox.Text = trivia.getRandomClue();
            }
        }

        private void option2_Click(object sender, EventArgs e)
        {
            int newRoom = Int16.Parse(option2.Text);
            if (map.movePlayer(newRoom))
            {
                turns++;
                int realRoom = map.getRoom();
                room.Text = "" + realRoom;
                checkHazards(realRoom);
                int trueRoom = map.getRoom();
                updateButtons(trueRoom);
                updateCoins();
                updateScoreTracker();
                ClueBox.Text = trivia.getRandomClue();
            }
        }

        private void option3_Click(object sender, EventArgs e)
        {
            int newRoom = Int16.Parse(option3.Text);
            if (map.movePlayer(newRoom))
            {
                turns++;
                int realRoom = map.getRoom();
                room.Text = "" + realRoom;
                checkHazards(realRoom);
                int trueRoom = map.getRoom();
                updateButtons(trueRoom);
                updateCoins();
                updateScoreTracker();
                ClueBox.Text = trivia.getRandomClue();
            }
        }


        private void zGameForm_Load(object sender, EventArgs e)
        {

        }

        private void buyArrows_Click(object sender, EventArgs e)
        {
            turns++;
            if (trivia.threeQuestions())
            {
                arrows += 2;
                updateScoreTracker();
                dialogue.Text = "You won arrows!";
            }
            updateScoreTracker();
        }

        private void dialogue_TextChanged(object sender, EventArgs e)
        {

        }

        private void shoot1_Click(object sender, EventArgs e)
        {
            turns++;
            arrows--;
            updateScoreTracker();
            int newRoom = Int16.Parse(option1.Text);
            if (map._Cave.wumpusInRoom(newRoom))
            {
                if (!dialogue.Text.Equals("You lose."))
                {
                    dialogue.Text = "You win.";
                }
            }
        }

        private void shoot2_Click(object sender, EventArgs e)
        {
            turns++;
            arrows--;
            updateScoreTracker();
            int newRoom = Int16.Parse(option2.Text);
            if (map._Cave.wumpusInRoom(newRoom))
            {
                if (!dialogue.Text.Equals("You lose."))
                {
                    dialogue.Text = "You win.";
                }
            }
        }

        private void shoot3_Click(object sender, EventArgs e)
        {
            turns++;
            arrows--;
            updateScoreTracker();
            int newRoom = Int16.Parse(option3.Text);
            if (map._Cave.wumpusInRoom(newRoom))
            {
                if (!dialogue.Text.Equals("You lose."))
                {
                    dialogue.Text = "You win.";

                }
            }
        }

        private void buySecret_Click(object sender, EventArgs e)
        {
            turns++;
            if (trivia.threeQuestions())
            {
                dialogue.Text = "You won a secret!";
                var r = new Random();
                int randSecretType = r.Next(1, 5);
                if (randSecretType == 1) //where bats are
                {
                    for (int i = 1; i <= map._Cave.numberOfRooms(); i++)
                    {
                        if (map._Cave.batsInRoom(i) == true)
                        {
                            label1.Text = "There are bats in room " + Convert.ToString(i) + ".";
                        }
                    }
                }
                else if (randSecretType == 2) //where pit is
                {
                    for (int i = 1; i <= map._Cave.numberOfRooms(); i++)
                    {
                        if (map._Cave.pitInRoom(i) == true)
                        {
                            label1.Text = "There is a pit in room " + Convert.ToString(i) + ".";
                        }
                    }
                }
                else if (randSecretType == 3) //where wumpus is
                {
                    for (int i = 1; i <= map._Cave.numberOfRooms(); i++)
                    {
                        if (map._Cave.wumpusInRoom(i) == true)
                        {
                            label1.Text = "The Wumpus is in room " + Convert.ToString(i) + ".";
                        }
                    }
                }
                else //where player is
                {
                    int playerRoom = map.getRoom();
                    label1.Text = "You are in room " + Convert.ToString(playerRoom) + ".";
                }
            }
        }

        private void SecretBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            button2.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
