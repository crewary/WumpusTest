using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WumpusTest2010
{
    class Cave
    {
        Room[] rooms;
        int numOfRooms;

        public Cave()
        {
    
        }

        public int numberOfRooms()
        {
            return numOfRooms;
        }

        /// <summary>
        /// The next three methods check to see if any of the hazards are present in a particular room
        /// </summary>
        /// <param name="roomNum"></param> the room the caller is inquiring about is passed as a parameter
        /// <returns></returns> they return true or false depending on whether or not a hazard is present
        public Boolean batsInRoom(int roomNum)
        {
            return rooms[roomNum - 1].BatsPresent;      
        }

        public Boolean pitInRoom(int roomNum)
        {
           return rooms[roomNum - 1].PitPresent;
        }

        public Boolean wumpusInRoom(int roomNum)
        {
           return rooms[roomNum - 1].WumpusPresent;
        }
        
        /// <summary>
        /// The next three methods check to see if any hazards are present in the adjacent rooms
        /// </summary>
        /// <param name="roomNum"></param> The room the caller is inquiring about is passed as a parameter
        /// <returns></returns> returns true or false depending on whether or not a hazard is in an adjacent room
        public Boolean areBatsNear(int roomNum)
        {
           Room thisRoom = rooms[roomNum - 1];
           int[] theseTunnels = thisRoom.Tunnels();
           for(int i = 0; i < 3; i++)
           {
              if(theseTunnels[i] != -1 && (batsInRoom(theseTunnels[i]) == true))
              {
                 return true;
              }
           }
           return false;
        }

        public Boolean isPitNear(int roomNum)
           {
           Room thisRoom = rooms[roomNum - 1];
           int[] theseTunnels = thisRoom.Tunnels();
           for (int i = 0; i < 3; i++)
              {
              if (theseTunnels[i] != -1 && (pitInRoom(theseTunnels[i]) == true))
                 {
                 return true;
                 }
              }
           return false;
           }

        public Boolean isWumpusNear(int roomNum)
           {
           Room thisRoom = rooms[roomNum - 1];
           int[] theseTunnels = thisRoom.Tunnels();
           for (int i = 0; i < 3; i++)
              {
              if (theseTunnels[i] != -1 && (wumpusInRoom(theseTunnels[i]) == true))
                 {
                 return true;
                 }
              }
           return false;
           }
        
        /// <summary>
        /// This method gets the string warning for each type of hazard if it is near
        /// </summary>
        /// <param name="roomNum"></param>
        /// <returns></returns>
        public String getWarning(int roomNum)
           {
               if(areBatsNear(roomNum) == true)
               {
                  return "Bats Nearby";
               }
               else if(isPitNear(roomNum) == true)
               {
                  return "I feel a draft!";
               }
               else if(isWumpusNear(roomNum) == true)
               {
                  return "I smell a Wumpus!";
               }
               else
               {
                  return "";
               }
           }
        
        /// <summary>
        /// This program moves the bats to a different room when they pick the player up and carry them away
        /// </summary>
        /// <param name="fromRoom"></param> you are passing the room the bats are coming from, NOT where you are putting them
        public void moveBats(int fromRoom) 
        {
            rooms[fromRoom - 1].BatsPresent = false;
            int toRoom = getRandomRoom();
            rooms[toRoom - 1].BatsPresent = true; 
        }
        
        /// <summary>
        /// This program moves the wumpus to a different room when it is disturbed
        /// </summary>
        /// <param name="fromRoom"></param> you are passing the room the wumpus is coming from, NOT where you are putting it
        public void moveWumpus(int fromRoom)  
        {
           rooms[fromRoom - 1].WumpusPresent = false;
           int[] roomSpecificTunnels = rooms[fromRoom - 1].Tunnels();
           int numTuns = numberOfTunnels(roomSpecificTunnels);
           var r = new Random();
           int randIndex = r.Next(0, numTuns);
           int toRoom = roomSpecificTunnels[randIndex];
           rooms[toRoom].WumpusPresent = true;
        }

        private int numberOfTunnels(int[] tunnels)
        {
            int count = 0;
            for(int i = 0; i < tunnels.Length; i++)
            {
               if(tunnels[i] != -1)
               {
                  count++;
               }
            }
            return count;
        }
        
        public Boolean readMap(int i)
        {
            if (i < 1 || i > 5)
            {
                return false;
            }
            
            return readMap("Cave " + i.ToString() + ".txt");                
        }


        /// <summary>
        /// This method will attempt to read and parse map data from a file
        /// If this is successful, it will return true
        /// </summary>
        /// <param name="fileName"> the name of the file containing map data </param>
        /// <returns> true means reading and parsing successful, false means unsuccessful </returns> 
        public Boolean readMap(String fileName)
        {
            // tries to open and read file that contains map data
            try
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(fileName);

                // parsing first line to get the total number of rooms
                String line = objReader.ReadLine();
                numOfRooms = Int16.Parse(line);
                rooms = new Room[numOfRooms];

                // parsing text to find each room number and the rooms it connects to through tunnels
                char[] splitChars = { '\t', ','};
                int roomNum;
                Boolean batsPresent;
                Boolean pitPresent;
                Boolean wumpusPresent;
                
                for (int i = 0; i < numOfRooms; i++)
                {
                    int[] tunnels = new int[3];
                    batsPresent = false;
                    pitPresent = false;
                    wumpusPresent = false;
                    line = objReader.ReadLine();
                    String[] splitStrings = line.Split(splitChars);
                    roomNum = Int16.Parse(splitStrings[0]);
                    String hazard = splitStrings[1];
                    if(hazard == "B")
                    {
                        batsPresent = true;
                    } else if(hazard == "P")
                    {
                        pitPresent = true;
                    } else if(hazard == "W")
                    {
                        wumpusPresent = true;
                    }
                        
                    for (int j = 0; j < 3; j++)
                    {
                        if (j < (splitStrings.Length - 2))
                        {
                            tunnels[j] = Int16.Parse(splitStrings[j + 2]);
                        }
                        else
                        {
                            tunnels[j] = -1;
                        }
                    }
                    rooms[i] = new Room(roomNum, tunnels, batsPresent, pitPresent, wumpusPresent);
                }

                objReader.Close();
                return true;

            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// This method returns the numbers of all the adjacent rooms that can possibly be moved to from the room that is passed to the method
        /// </summary>
        /// <param name="room"> the room being inquired about </param>
        /// <returns> numbers of the adjacent rooms that can be moved to through tunnels</returns>
        public int[] possibleRooms(int roomNum)
        {
            roomNum--;
            Room theRoom = rooms[roomNum];
            /// this will give the array that tells you the numbers of the rooms you can move to, bro
            return theRoom.Tunnels();
        }

        public bool areRoomsConnected(int first, int second)
        {
            int[] possible = possibleRooms(first);
            for (int i = 0; i < possible.Length; i++)
            {
                if(possible[i] == second) {
                    return true;
                }
            }
            return false;
        }
        
        /// <summary>
        /// This method is called when superbats are encountered and a random room must be chosen
        /// </summary>
        /// <returns> the number of a random room</returns>
        public int getRandomRoom()
        {
            var r = new Random();
            // print random integer >= 0 and  < 100
            int randRoom = r.Next(1, numOfRooms + 1);
            return randRoom;
        }

        /// <summary>
        /// This method checks a room to see if there is a bottomless pit in it
        /// </summary>
        /// <param name="room"> the number of the room being tested</param>
        /// <returns> true or false depending on whether or not the bottomless pit exists </returns>
        
    }
}
