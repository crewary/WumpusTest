using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; //might not need
namespace WumpusTest2010
{
    class HighScore
    {
        private static String startPath = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WumpusTest");
        //@"C:\Users\s-thnguyen\Documents\Visual Studio 2010\Projects\WumpusTest";
        public static int numberOfHighScores = 10;  //dont change this randomly.. fix/delete Highscores.txt as well
        private String[,] highScoreParts;   //Rectangular String array holding parts of highsore [numberOfHighScores] x [score, coins, arrows, turn, name]
        private static String fileName = "tempHighScores.txt";  //write new scores here and rename to HighScores.txt
        private static String scoresFolderPath = System.IO.Path.Combine(startPath, "HighScores");
        private static String scoresFilePath = System.IO.Path.Combine(scoresFolderPath, "HighScores.txt");  //contains old scores
        private static String filePath = System.IO.Path.Combine(scoresFolderPath, fileName);

        public HighScore()
        {
        }

        /// <summary>
        /// Read all scores and names from text file and put into rectangular string array for access.
        /// 10 sets of a score, coins, arrows, turns, name
        /// WILL BE IN STRING SO PARSE IF NEEDED
        /// {1-10}{Score, Coins, Arrows, Turns, Name} 
        /// </summary>
        /// <returns>Rectangular array of score components</returns>
        public String[,] ScoreComponents()
        {
            this.CheckHighScoresPresent();

            String[,] scoreStuff = new String[numberOfHighScores, 5];
            String[] lines = System.IO.File.ReadAllLines(scoresFilePath);   //unseparated String containing player data

            //splits the lines array and places invidual scores and name into scoreStuff cells to return later
            for (int i = 0; i < numberOfHighScores; i++)
            {
                String[] line = lines[i].Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
                for (int k = 0; k <= 3; k++)
                {
                    scoreStuff[i, k] = line[k];
                }
                int lengthOfArray = line.Length;
                String playerName = "";
                for (int p = 4; p < lengthOfArray; p++)
                {
                    playerName += line[p] + " ";
                }
                scoreStuff[i, 4] = playerName;

                //Can Comment out
                //diplay formatted array lines in console
                Console.WriteLine("" + scoreStuff[i, 0] + " " + scoreStuff[i, 1] + " " + scoreStuff[i, 2] + " " + scoreStuff[i, 3] + " " + scoreStuff[i, 4]);
                //
            }
            Console.WriteLine();
            highScoreParts = scoreStuff;
            return scoreStuff;
        }

        /// <summary>
        /// Calculate and return score from number of coins, arrows, and turns taken
        /// </summary>
        /// <param name="coins">Number of coins player acquired at point</param>
        /// <param name="arrows">Number of arrows player acquired at point</param>
        /// <param name="turns">Number of turns taken by player</param>
        /// <returns>Calculated score</returns>
        public int CalculateScore(int coins, int arrows, int turns)
        {
            return (100 - turns + coins + (10 * arrows));
        }

        /// <summary>
        /// Take text file with highscores and current player high score
        /// and update highscores if player made into highscores
        /// returns true if scores are updated
        /// </summary>
        /// <param name="name">Name of player</param>
        /// <param name="playerHighScore">Player's highscore</param>
        /// <param name="coins">Number of coins player acquired at point</param>
        /// <param name="arrows">Number of arrows player acquired at poin</param>
        /// <param name="turns">Number of turns taken by player</param>
        /// <returns>True if scores are updated</returns>
        public bool UpdateHighScores(String name, int playerHighScore, int coins, int arrows, int turns)
        {
            this.CheckHighScoresPresent();

            String[] oldScores = System.IO.File.ReadAllLines(scoresFilePath);
            String[] newScores = new String[numberOfHighScores];

            bool areWeDone = false;
            int counter = 0;

            //checks player score against old scores and knocks off last player or will set up a false return for a non-highscore
            while (counter < numberOfHighScores && !areWeDone)
            {
                String oldScoreString = "";
                foreach (char c in oldScores[counter])  //gets the old scores to be compared against
                {
                    if (!Char.IsDigit(c))
                    {
                        break;
                    }
                    oldScoreString += c;
                }

                int oldScore = Int32.Parse(oldScoreString);

                bool scorePlaced = false;
                if (playerHighScore < oldScore && !scorePlaced)     //checks if current player displaces highscores
                {
                    newScores[counter] = oldScores[counter];    //copies old highscore entry to new array when not displaced by current player
                    counter++;
                    scorePlaced = true;     //continue to check current player score through old scores
                }
                else if (playerHighScore >= oldScore && !scorePlaced)   //current player score displaces highscores... knock last place out and copy rest of scores
                {
                    newScores[counter] = "" + playerHighScore + " " + coins + " " + arrows + " " + turns + " " + name;  //String of current player's data formatted
                    while ((counter + 1) < numberOfHighScores)      //copies all old scores over, excluding the knocked out score and sets up exit of while loop
                    {
                        newScores[counter + 1] = oldScores[counter];
                        counter++;
                    }
                    areWeDone = true;
                }
            }

            //write scores to temp file
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
            {
                foreach (string line in newScores)
                {
                    file.WriteLine(line);
                }
            }
            if (System.IO.File.Exists(scoresFilePath))
            {
                System.IO.File.Delete(scoresFilePath);
            }
            System.IO.File.Move(filePath, scoresFilePath); //rename temp file to actual file
            return areWeDone;
        }

        /// <summary>
        /// Opens the HighScore form
        /// </summary>
        public void openHighScoreForm()
        {
            HighScoresForm hs = new HighScoresForm();
            hs.ShowDialog();
        }

        /// <summary>
        /// Checks if HighScores folder and file is present, will create if not
        /// </summary>
        public void CheckHighScoresPresent()
        {
            String scoresFolderPath = System.IO.Path.Combine(startPath, "HighScores");
            String scoresFilePath = System.IO.Path.Combine(scoresFolderPath, "HighScores.txt");
            String filePath = System.IO.Path.Combine(scoresFolderPath, fileName);

            String[] fillEmpty = new String[numberOfHighScores];
            if (!System.IO.Directory.Exists(scoresFolderPath))
            {
                System.IO.Directory.CreateDirectory(scoresFolderPath);
            }
            if (!System.IO.File.Exists(scoresFilePath))
            {
                for (int i = 0; i < numberOfHighScores; i++)
                {
                    fillEmpty[i] = "0 0 0 0 Player" + (i + 1);      //This array will have the format of the necessary amount of empty player scores written to the text file
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
                {
                    foreach (string line in fillEmpty)
                    {
                        file.WriteLine(line);
                    }
                }
                System.IO.File.Move(filePath, scoresFilePath); //rename file
            }
        }

    }
}
