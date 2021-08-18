using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_And_Seek
{
    class ProgramUI
    {
        Dictionary<string, House> rooms = new Dictionary<string, House>
        {
            { "Living Room" , LivingRoom },
            {"Front Yard" , FrontYard },
            {"Kitchen" , Kitchen },
            {"Master Bedroom" , MasterBedroom },
            {"Bedroom" , Bedroom },
            {"Long Hall Way" , LongHallWay },
            {"Bath Room" , BathRoom },

        };
        public static House BathRoom = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
          new List<string> { "Fron Yard", "Kitchen" },
          new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
          "You are in the Living Room. It has a lamp, a long brown leather couch against the wall, " +
          "an entertainment center with a tv on top, a front door leading to the driveway, and a closet near the front door");

        public static House Bedroom = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
          new List<string> { "Fron Yard", "Kitchen" },
          new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
          "You are in the Living Room. It has a lamp, a long brown leather couch against the wall, " +
          "an entertainment center with a tv on top, a front door leading to the driveway, and a closet near the front door");

        public static House FrontYard = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
          new List<string> { "Fron Yard", "Kitchen" },
          new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
          "You are in the Living Room. It has a lamp, a long brown leather couch against the wall, " +
          "an entertainment center with a tv on top, a front door leading to the driveway, and a closet near the front door");

        public static House LivingRoom = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
            new List<string> { "Fron Yard", "Kitchen"},
            new List<string> { "Front Yard Exit", "Kitchen Exit", "Master Bedroom Exit", "Bedroom Exit" },
            "You are in the Living Room. It has a lamp, a long brown leather couch against the wall, " +
            "an entertainment center with a tv on top, a front door leading to the driveway, and a closet near the front door");



        public static House Kitchen = new House(new List<string> { "cabinets", "island", "oven" },
            new List<string> { "LivingRoom" },
            new List<string> { "Living Room Exit" },

            "You are in the kitchen. Along the wall is a section of cabinets with enough space to hide in them.\n\n" +
           "on top of the cabinets is cooking surface with a microwave, coffee maker, sink, and dishes.\n\n +" +
            " In the middle of the kitchen is an island. It has chairs on all sides. You can not see \n\n" +
            "what is on the other side of the island. \n\n" +
            "You can go back into the Living Room \n\n" +
            "You can try to find the computer behind the island. \n\n" +
            "you can try to find the computer in the cabinets \n\n" +
            "you can try to find the computer inside the oven\n\n");

        public static House LongHallWay = new House(
            new List<string> { },
            new List<string> { "LivingRoom", "Master Bedroom", "Bedroom", "Bathroom", "Back yard" },
            new List<string> { "Master Bedroom Exit", "Bedroom Exit", "Bathroom" },
            "You are in the long Hallway that leads to the Master Bed Room, another Bedroom, a bathroom, and has a door leading to the back yard\n\n" +
            "The floor is made of tile and the halway is about 6 feet wide and is 30 feet long \n\n" +
            "There is nowhere to hide in the hall way\n\n" +
            "You can go into the back yard\n" +
            "You can go into the Master Bedroom\n" +
            "You can go into the BedRoom\n" +
            "You can go into the Bathroom");
        public static House MasterBedroom = new House(
            new List<string> {"Dresser one" , "Dresser Two","Closet","Bed"},
            new List<string> {"Hallway" },
            new List<string> { "Hallway Exit"},
            "You are in the Master Bedroom\n" +
            "It has a king size bed. It has two windows. It has two dressers. It has one closet\n\n" +
            "You can check under the bed\n" +
            "you can check behind Dresser number one\n" +
            "You can check behind Dresser number two\n" +
            "You can check inside the closet\n" +
            "You can go back into the hallway"
            );
            
        public void Run()
        {
            House currentroom = LivingRoom;

            var randomroom = new Random();
            var roomlist = new List<string> { "MasterBedroom", "BedRoom", "Kitchen", "BathRoom", "LongHallWay", "FrontYard" , "BackYard" , "LivingRoom", "DriveWay"};
            int roomindex = randomroom.Next(roomlist.Count);
            Console.WriteLine(roomlist[roomindex]);
            string room  =  roomlist[roomindex];
            if(room == "MasterBedroom")
            {
                var randomhideout = new Random();
                int hideout =  randomhideout.Next(MasterBedroom.HidingObjects.Count);
                string hiddingplace  =  MasterBedroom.HidingObjects[hideout];
            }
            else if(room == "Bedroom")
            {
                RandomString("Bedroom");
                
            }
            else if(room == "Kitchen")
            {
                RandomString("Kitchen");
            }
            else if(room == "BathRoom")
            {
                RandomString("BathRoom");
            }
            else if(room == "LongHallWay")
            {
                RandomString("LongHallWay");
            }
            else if (room == "FrontYard")
            {
                RandomString("FrontYard");
            }
            else if (room == "BackYard")
            {
                RandomString("BackYard");
            }
            else if (room == "LivingRoom")
            {
                RandomString("LivingRoom");
            }
            else if (room == "Driveway")
            {
                RandomString("Driveway");
            }


            bool foundComputer = false;
            House PresentHouse = LivingRoom;
            bool continueplaying = true;
            while (continueplaying)
            {
                Console.Clear();
                Console.WriteLine(LivingRoom.Message)
                string interactnavcommand = Console.ReadLine().ToLower();
                if (interactnavcommand.StartsWith"enter")
            }



            
        }
        private string  RandomString(string room)
        {
            House house = rooms[room];
            var randomhideout = new Random();
            int hideout = randomhideout.Next(house.HidingObjects.Count);
            string hiddingplace = house.HidingObjects[hideout];
            return hiddingplace;
        }

        private void MovetoNextRoom(string roomname)
        {
            Console.WriteLine("Move tho the next room ");
            string response= Console.

        }

        public void homescreensplash()
        {
            Console.WriteLine("Welcome to hide and seek!\n\n" +
               "In this game you will be playing hide and seek with the computer\n" +
               "Each time you begin a new game the computer will be hiding somewhere else\n\n" +

               "You will begin the game in the Living Room\n" +
               "When you enter each room places to seek for the hiding computer as \n" +
               "well as places you can go will be diplayed\n\n " +

               "To move to a different room enter 'move to' followed by the \n" +
               "name of the room. ex. 'move to kitchen'.\n\n" +

               "To check objects in the room for the hiding computer enter 'check'\n" +
               "followed by the name of the object. ex. 'check couch'.\n\n" +

               "When you do find the computer you will be sent back to this splash screen\n\n" +

               "GOOD LUCK!"
               );
        }


        


        
        
          
        
        
        
        
    }
}
