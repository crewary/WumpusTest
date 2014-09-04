using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest2010
{
    public class Room
    {
        int roomNum;
        int[] tunnels;
        Boolean batsPresent;
        Boolean pitPresent;
        Boolean wumpusPresent;

        public Room(int roomNumber, int[] connectTunnels, Boolean batsPresent, Boolean pitPresent, Boolean wumpusPresent)
        {
            roomNum = roomNumber;
            tunnels = connectTunnels;
            this.batsPresent = batsPresent;
            this.pitPresent = pitPresent;
            this.wumpusPresent = wumpusPresent;
        }

        public Boolean BatsPresent
        {
            get
            {
                return batsPresent;
            }
            set
            {
                batsPresent = value;
            }
        }

        public Boolean PitPresent
        {
            get
            {
                return pitPresent;
            }
            set
            {
                pitPresent = value;
            }
        }

        public Boolean WumpusPresent
        {
            get
            {
                return wumpusPresent;
            }
            set
            {
                wumpusPresent = value;
            }
        }

        public int[] Tunnels()
        {
            return tunnels;
        }
    }

}
