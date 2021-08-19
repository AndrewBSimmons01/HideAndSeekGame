using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_And_Seek
{
    class ProgramUI
    {
        public void HomeScreenSplash()
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

               "GOOD LUCK!");
            Console.ReadKey();
            Console.Clear();

        }


        Dictionary<string, House> rooms = new Dictionary<string, House>
        {
            { "LivingRoom" , LivingRoom },
            {"FrontYard" , FrontYard },
            {"Kitchen" , Kitchen },
            {"MasterBedroom" , MasterBedroom },
            {"Bedroom" , Bedroom },
            {"LongHallWay" , LongHallWay },
            {"BathRoom" , BathRoom },
            {"BackYard" , BackYard },

        };


        public static House BackYard = new House(new List<string> { "Trampoline", "Tree", "lawn mower" },
          new List<string> { "LongHallWay" },
          new List<string> { " " },
          "You are in the Back Yard. You are standing on a small wooden porch\n" +
            " with 3 stairs at the end leading into the grass\n" +
            "The yard has a tall wooden fence. To the left there is a trampoline.\n " +
            "to the right there is a rather large tree with a tire swing\n" +
            "Your dad left the Riding Lawn Mower in your yard.\n" +
            "Hope he comes to get it someday. Does it even work?\n\n" +
            "You Can check under the trampoline." +
            "You Can check behind the tree" +
            "You Can check behind the lawn mower.\n\n" +
            "You can go back into the HallWay");
        public static House BathRoom = new House(new List<string> { "Shower" },
          new List<string> { "LongHallWay" },
          new List<string> { " " },
          "You are in the Bathroom. It is a typical bath room.\n" +
            "The only place to hide here is inside of the shower.\n" +
            "The shower is a stall with a door that has frosted glass \n" +
            "you can not see inside.\n\n " +
            "You can check inside of the shower\n" +
            "You can go back into the Hall Way");

        public static House Bedroom = new House(new List<string> { "boxes", "exercise bike", "clothes rack" },
          new List<string> { "Longhallway" },
          new List<string> { " " },
          "You are in the Bed Room.\n" +
            " This bed room has been converted to storage. \n" +
            "The floor is made of wood. There is a ceiling fan.\n" +
            "There is a stack of boxes. There is an exercise bike.\n" +
            " There is a rack for hanging clothes.\n" +
            "You can check behind the boxes.\n" +
            "You can check behind the exercise bike.\n" +
            "You can check behind the clothes rack.\n\n" +
            "You Can go back into the Hall Way\n");

        public static House FrontYard = new House(new List<string> { "Behind Car", "In the Car", "Left side of house", "Right side of house" },
          new List<string> { "LivingRoom" },
          new List<string> { " " },
          "You are in the Front Yard.\n" +
            " To the left is a Drive Way with a car in it. \n" +
            "The house has houses to the left and right of it\n" +
            "Between the houses is grass.\n " +
            "You can check behind the car.\n" +
            "You can check in the car.\n" +
            "You can check the left side of the house.\n" +
            "You can check the right side of the house\n\n" +
            "You can go back into the Living Room.");

        public static House LivingRoom = new House(new List<string> { "Couch", "Entertainment center", "Closet" },
            new List<string> { "Front Yard", "Kitchen" },
            new List<string> { " " },
            "You are in the Living Room.\n" +
            " It has a lamp, a long brown leather couch against the wall, " +
            "an entertainment center with a tv on top,\n" +
            " a front door leading to the driveway, and a closet near the front door");



        public static House Kitchen = new House(new List<string> { "cabinets", "island", "oven" },
            new List<string> { "LivingRoom" },
            new List<string> { "Living Room Exit" },

            "You are in the kitchen.\n" +
            " Along the wall is a section of cabinets\n" +
            "with enough space to hide in them." +
           "on top of the cabinets is cooking surface\n" +
            " with a microwave, coffee maker, sink, and dishes.\n\n +" +
            " In the middle of the kitchen is an island.\n" +
            " It has chairs on all sides. You can not see \n\n" +
            "what is on the other side of the island. \n\n" +
            "You can go back into the Living Room \n\n" +
            "You can check behind the island. \n\n" +
            "You can check in the cabinets. \n\n" +
            "You can check inside the oven.\n\n");

        public static House LongHallWay = new House(
            new List<string> { },
            new List<string> { "LivingRoom", "Master Bedroom", "Bedroom", "Bathroom", "Back yard" },
            new List<string> { " " },
            "You are in the long Hallway that leads to the Master Bed Room,\n" +
            " another Bedroom, a bathroom, and has a door\n" +
            " leading to the back yard\n\n" +
            "The floor is made of tile and the halway is \n" +
            "about 6 feet wide and is 30 feet long \n\n" +
            "There is nowhere to hide in the hall way\n\n" +
            "You can go into the back yard\n" +
            "You can go into the Master Bedroom\n" +
            "You can go into the BedRoom\n" +
            "You can go into the Bathroom");
        public static House MasterBedroom = new House(
            new List<string> { "Dresser one", "Dresser Two", "Closet", "Bed" },
            new List<string> { "Hallway" },
            new List<string> { "" },
            "You are in the Master Bedroom\n" +
            "It has a king size bed. It has two windows.\n" +
            " It has two dressers. It has one closet\n\n" +
            "You can check under the bed\n" +
            "you can check behind Dresser number one\n" +
            "You can check behind Dresser number two\n" +
            "You can check inside the closet\n" +
            "You can go back into the hallway"
            );

        //public string RandomLocationOfHouse(string room)
        //{
        //    House house = rooms[room];
        //    var randomhideout = new Random();
        //    int hideout = randomhideout.Next(0, house.HidingObjects.Count - 1);
        //    string place = house.HidingObjects[hideout];
        //    return place;
        //}


        public string RandomHouseLocation()
        {
            var randomroom = new Random();
            var roomlist = new List<string> { "MasterBedroom", "Bedroom", "Kitchen", "BathRoom", "FrontYard", "BackYard", "LivingRoom" };
            int roomindex = randomroom.Next(0, roomlist.Count - 1);
            string room = roomlist[roomindex];
            return room;
        }

        public string RandomLocationWithinRoom()
        {
            string room = RandomHouseLocation();

            switch (room)
            {
                case "MasterBedroom":
                    List<string> masterRoomList = new List<string> { "bed", "dresser number 1", "dresser number 2", "closet" };
                    var randomObject1 = new Random();
                    int objectIndex = randomObject1.Next(0, masterRoomList.Count);
                    string masterRoomLocation = masterRoomList[objectIndex];
                    return masterRoomLocation;


                case "bedroom":
                    List<string> bedroomList = new List<string> { "boxes", "exercise bike", "clothes rack" };
                    var randomObject2 = new Random();
                    int objectIndex2 = randomObject2.Next(0, bedroomList.Count);
                    string bedRoomRoomLocation = bedroomList[objectIndex2];
                    return bedRoomRoomLocation;

                case "kitchen":
                    List<string> kitchenroomList = new List<string> { "cabinets", "island", "oven" };
                    var randomObject3 = new Random();
                    int objectIndex3 = randomObject3.Next(0, kitchenroomList.Count);
                    string kitchenRoomLocation = kitchenroomList[objectIndex3];
                    return kitchenRoomLocation;

                case "bathroom":
                    List<string> bathroomroomList = new List<string> { "shower" };
                    var randomObject4 = new Random();
                    int objectIndex4 = randomObject4.Next(0, bathroomroomList.Count);
                    string bathroomRoomLocation = bathroomroomList[objectIndex4];
                    return bathroomRoomLocation;

                case "frontyard":
                    List<string> frontyardroomList = new List<string> { "behindCar", "intheCar", "leftsideofhouse", "rightsideofhouse" };
                    var randomObject5 = new Random();
                    int objectIndex5 = randomObject5.Next(0, frontyardroomList.Count);
                    string frontyardRoomLocation = frontyardroomList[objectIndex5];
                    return frontyardRoomLocation;

                case "backyard":
                    List<string> backyardroomList = new List<string> { "trampoline", "tree", "lawnmower" };
                    var randomObject6 = new Random();
                    int objectIndex6 = randomObject6.Next(0, backyardroomList.Count);
                    string backyardRoomLocation = backyardroomList[objectIndex6];
                    return backyardRoomLocation;

                case "livingroom":
                    List<string> livingroomList = new List<string> { "couch", "entertainment center", "closet" };
                    var randomObject7 = new Random();
                    int objectIndex7 = randomObject7.Next(0, livingroomList.Count);
                    string livingroomlocation = livingroomList[objectIndex7];
                    return livingroomlocation;
            }
            return null;

        }

        public void LocationCheck(string userInput)
        {
            string location = RandomLocationWithinRoom();

            if (userInput == location)
            {
                Console.WriteLine("Congrats you win!!");
            }
            else
            {
                Console.WriteLine("It's not here.");
            }



        }




        //var randomhideout = new random();
        //int hideout = randomhideout.next(1, masterbedroom.hidingobjects.count);
        //hiddingplace = masterbedroom.hidingobjects[hideout];

        public void Run()
        {
            HomeScreenSplash();
            RandomLocationWithinRoom();

            //House currentroom = LivingRoom;
            //string hiddingplace = " ";

            //var randomroom = new Random();
            //var roomlist = new List<string> { "MasterBedroom", "Bedroom", "Kitchen", "BathRoom", "FrontYard", "BackYard", "LivingRoom" };
            //int roomindex = randomroom.Next(0, roomlist.Count - 1);
            //string room = roomlist[roomindex];
            bool running = false;

            Console.WriteLine(LivingRoom.Message);

            while (running = true)
            {
                string interactnavcommand = Console.ReadLine().ToLower();
                if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" masterbedroom"))
                {
                    WhileInMasterBedroom();
                }
                else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" bedroom"))
                {
                    Console.WriteLine(Bedroom.Message);
                    string check = Console.ReadLine().ToLower();
                    if (check.Contains("check ") && check.Contains("boxes") || check.Contains("exercise bike") || check.Contains("clothes rack"))
                    {
                        LocationCheck(check);

                    }
                }
                else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" kitchen"))
                {
                    Console.WriteLine(Kitchen.Message);
                    string check = Console.ReadLine().ToLower();
                    if (check.Contains("check ") && (check.Contains("cabinets") || check.Contains("island") || check.Contains("oven")))
                    {
                        LocationCheck(check);
                    }

                }
                else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" bathroom"))
                {
                    Console.WriteLine(BathRoom.Message);
                    string check = Console.ReadLine().ToLower();
                    if (check.Contains("check ") && check.Contains("shower"))
                        LocationCheck(check);
                }
                else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" long hall way"))
                {
                    Console.WriteLine(LongHallWay.Message);
                }
                else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" front yard"))
                {
                    Console.WriteLine(FrontYard.Message);
                    string check = Console.ReadLine().ToLower();
                    if (check.Contains("check ") && check.Contains("behindthecar") || check.Contains("inthecar") || check.Contains("leftsideofhouse") || check.Contains("rightsideofhouse"))
                        LocationCheck(check);
                }
                else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" back yard"))
                {
                    Console.WriteLine(BackYard.Message);
                    string check = Console.ReadLine().ToLower();
                    if (check.Contains("check ") && check.Contains("trampoline") || check.Contains("tree") || check.Contains("lawnmower"))
                        LocationCheck(check);
                }
                else if (interactnavcommand.Contains("move to") && interactnavcommand.Contains(" living room"))
                {
                    Console.WriteLine(LivingRoom.Message);
                    string check = Console.ReadLine().ToLower();
                    if (check.Contains("check ") && check.Contains("couch") || check.Contains("entertainmentcenter") || check.Contains("closet"))
                        LocationCheck(check);
                }
                else
                {
                    Console.WriteLine("Make another selection");
                }
            }


        }
        public void WhileInMasterBedroom()
        {
            Console.Clear();
            Console.WriteLine(MasterBedroom.Message);
            Console.ReadKey();

            bool inBedroom = true;

            while (inBedroom)
            {
                string check = Console.ReadLine().ToLower();
                if (check.Contains("check ") && (check.Contains("Dresser number 1") || check.Contains("Dresser number 2") || check.Contains("closet") || check.Contains("bed")))
                {
                    LocationCheck(check);
                }
                else if (check.Contains("leave"))
                {
                    inBedroom = false;
                }
            }

        }



        //bool keeprunning = true;
        //while (keeprunning)
        //if (room == "MasterBedroom")
        //{

        //}
        //else if (room == "Bedroom")
        //{
        //    var randomhideout = new Random();
        //    int hideout = randomhideout.Next(1,Bedroom.HidingObjects.Count);
        //     hiddingplace = MasterBedroom.HidingObjects[hideout];

        //}
        //else if (room == "Kitchen")
        //{
        //    var randomhideout = new Random();
        //    int hideout = randomhideout.Next(1,Kitchen.HidingObjects.Count);
        //     hiddingplace = MasterBedroom.HidingObjects[hideout];

        //}
        //else if (room == "BathRoom")
        //{
        //    var randomhideout = new Random();
        //    int hideout = randomhideout.Next(1,BathRoom.HidingObjects.Count);
        //     hiddingplace = MasterBedroom.HidingObjects[hideout];

        //}
        //else if (room == "LongHallWay")
        //{
        //    var randomhideout = new Random();
        //    int hideout = randomhideout.Next(1,LongHallWay.HidingObjects.Count);
        //     hiddingplace = MasterBedroom.HidingObjects[hideout];

        //}
        //else if (room == "FrontYard")
        //{
        //    var randomhideout = new Random();
        //    int hideout = randomhideout.Next(1,FrontYard.HidingObjects.Count);
        //     hiddingplace = MasterBedroom.HidingObjects[hideout];

        //}
        //else if (room == "BackYard")
        //{
        //    var randomhideout = new Random();
        //    int hideout = randomhideout.Next(1,BackYard.HidingObjects.Count);
        //     hiddingplace = MasterBedroom.HidingObjects[hideout];

        //}
        //else if (room == "LivingRoom")
        //{
        //    var randomhideout = new Random();
        //    int hideout = randomhideout.Next(1,LivingRoom.HidingObjects.Count);
        //     hiddingplace = MasterBedroom.HidingObjects[hideout];

        //}



        //bool foundComputer = false;
        //House PresentHouse = LivingRoom;
        //bool continueplaying = true;
        //while (continueplaying)
        //private void MovetoNextRoom(string roomname)
        //{

        //    if (roomname.Contains(roomname))
        //    {
        //        House house = rooms[roomname];
        //        Console.WriteLine(house.Message);
        //        Console.WriteLine("Do you want to check if he's inside the this room? enter y for yes and n for no ,");
        //        string response1 = Console.ReadLine();
        //        if (response1 == "y")
        //        {
        //            bool keeprunning = true;
        //            while (keeprunning)
        //            {
        //                Console.WriteLine("Open each hideout by pressing check + hideout");
        //                string response2 = Console.ReadLine();
        //                if (response2.Contains(place))
        //                {
        //                    Console.WriteLine("Hey you Won!");
        //                    break;

        //                }
        //                else
        //                {
        //                    Console.WriteLine(" you missed him,  do you still need to keep seraching Do you still need to seach for him? y for yes and n for no");
        //                    string response3 = Console.ReadLine().ToLower();
        //                    if (response3 == "n")
        //                    {
        //                        keeprunning = false;
        //                    }
        //                }

        //            }
        //        }




        //    }

        //}

        //string place;
        //Console.WriteLine("Open the hideout in the Living room to look for Mr Computer and enter the hideout from this list");
        //string response2 = Console.ReadLine().ToLower().Replace(" ","");
        //if (response2==RandomString(room))
        //{
        //    Console.WriteLine("Hey you Won!");
        //    break;

        //}
        //else
        //{
        //    Console.WriteLine("Else do you still need to keep seraching. Do you still need to seach for him? y for yes and n for no");
        //    string response3 = Console.ReadLine().ToLower();
        //    if (response3 == "n")
        //    {
        //        keeprunning = false;
        //    }
        //}


        //Console.WriteLine("Move tho the next room ");
        //string response = Console.ReadLine().ToLower();









    }

}

