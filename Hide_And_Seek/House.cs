using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_And_Seek
{
    class House
    {
        public List<string> Exits { get; }
        public List<string> Rooms { get; }
        public List<string> HidingObjects { get; }
        public string Message { get;  set; }
        public House(List<string> hidingobjects, List<string> exits, List<string> rooms, string message)
        {
            Exits = exits;
            Rooms = rooms;
            HidingObjects = hidingobjects;
            Message  =  message;
        }

    }
}
