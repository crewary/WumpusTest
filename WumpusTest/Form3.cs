using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest2010
{
    public partial class Form3 : Form
    {
        private Cave myCave;
        public Form3()
        {
            InitializeComponent();
            myCave = new Cave();
        }

        private int caveNum;

        //SWITCH THIS TO TAKE INT FROM BUTTON CLICK ON FORM
        public void ChooseYourCave()
        {
            Console.WriteLine("Which Cave would you like to play? Enter 1, 2, 3, 4, or 5.");
            caveNum = Console.Read();
        }

        private void CaveConstructOnClick(object sender, EventArgs e)
        {
            if (caveNum == 1)
            {
                myCave.readMap("Cave1.txt");
            }
            else if (caveNum == 2)
            {
                myCave.readMap("Cave2.txt");
            }
            else if (caveNum == 3)
            {
                myCave.readMap("Cave3.txt");
            }
            else if (caveNum == 4)
            {
                myCave.readMap("Cave4.txt");
            }
            else if (caveNum == 5)
            {
                myCave.readMap("Cave5.txt");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
