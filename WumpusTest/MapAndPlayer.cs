using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest2010
{
    class MapAndPlayer
    {
        public Cave _Cave = new Cave();
        private int playerRoom;
        public MapAndPlayer(int whichCave)
        {
            _Cave.readMap(whichCave);
            setRandomRoom();
        }
        public int getRoom()
        {
            return playerRoom;
        }
        public void setRoom(int room)
        {
            playerRoom = room;
        }

        public void setRandomRoom()
        {
            int original = playerRoom;
            do {
                Random gen = new Random();
                int newRoom = gen.Next(30) + 1;
                setRoom(newRoom);
            } while(_Cave.batsInRoom(playerRoom) || _Cave.wumpusInRoom(playerRoom) || _Cave.pitInRoom(playerRoom) || playerRoom == original); // help
        }
        /// <summary>
        /// checks if player can move into a room
        /// </summary>
        /// <param name="room">the room number</param>
        /// <returns>if player can move</returns>
        public bool movePlayer(int room)
        {
            
            if (_Cave.areRoomsConnected(playerRoom, room))
            {
                setRoom(room);
                return true;
            }
            return false;
        }
        /// <summary>
        /// checks if Wumpus is in room
        /// </summary>
        /// <param name="room">the room number</param>
        /// <returns>if Wumpus is in it</returns>
        /*public bool isWumpusInRoom(int room)
        {
            if (_Cave.wumpusRoom() == room)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// checks if Wumpus is shot
        /// </summary>
        /// <param name="room">the room number</param>
        /// <returns>if arrow kills Wumpus</returns>
        public bool isWumpusKilled(int room)
        {
            return false;
        }
        /// <summary>
        /// checks if first pit is in room
        /// </summary>
        /// <param name="room">the room number</param>
        /// <returns>if first pit is in it</returns>
        public bool IsPitOneInRoom(int room)
        {
            if (_Cave.pitOneRoom() == room)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// checks if second pit is in room
        /// </summary>
        /// <param name="room">the room number</param>
        /// <returns>if second pit is in it</returns>
        public bool IsPitTwoInRoom(int room)
        {
            if (_Cave.pitTwoRoom() == room)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// checks if first bat is in room
        /// </summary>
        /// <param name="room">the room number</param>
        /// <returns>if first bat is in it</returns>
        public bool IsBatOneInRoom(int room)
        {
            if (_Cave.batOneRoom() == room)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// checks if second bat is in room
        /// </summary>
        /// <param name="room">the room number</param>
        /// <returns>if second bat is in it</returns>
        public bool IsBatTwoInRoom(int room)
        {
            if (_Cave.batTwoRoom() == room)
            {
                return true;
            }
            return false;
        }*/
    }
}
