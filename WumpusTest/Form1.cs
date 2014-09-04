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
    public partial class Form1 : Form
    {
        private MapAndPlayer _MapAndPlayer;
        private String first = "";
        private int theFirstRoom = 0;
        private String other = "";
        private int theOtherRoom = 0;
        private String wumppus = "";
        private int theWumpusishRoom = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConstructorButton_Click(object sender, EventArgs e)
        {
            _MapAndPlayer = new MapAndPlayer(1);
            _MapAndPlayer.setRoom(theFirstRoom);
            if (_MapAndPlayer.movePlayer(theOtherRoom))
            {
                whether.Text = "True";
            }
            else
            {
                whether.Text = "False";
            }
        }

        private void firstRoom_TextChanged(object sender, EventArgs e)
        {
            first = firstRoom.Text;
            theFirstRoom = int.Parse(first);
        }

        private void newRoom_TextChanged(object sender, EventArgs e)
        {
            other = newRoom.Text;
            theOtherRoom = int.Parse(other);
            if(_MapAndPlayer.movePlayer(theOtherRoom)) {
                whether.Text = "No";
            }
            else
            {
                whether.Text = "Yes";
            }
        }

        private void whether_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void wumpus_TextChanged(object sender, EventArgs e)
        {
            wumppus = wumpus.Text;
            if(wumppus == "15") {
                isWumpusThere.Text = "Yes";
            }
            else
            {
                isWumpusThere.Text = "No";
            }
        }

        private void isWumpusThere_TextChanged(object sender, EventArgs e)
        {

        }

        private void originalRoom_Click(object sender, EventArgs e)
        {

        }

        private void otherRoom_Click(object sender, EventArgs e)
        {

        }

        private void whetha_Click(object sender, EventArgs e)
        {

        }

        private void moor_Click(object sender, EventArgs e)
        {

        }

        private void iz_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
