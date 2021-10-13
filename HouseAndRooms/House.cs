using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp
{
    class House
    {
        public string Name { get; set; }
        public Room[] Rooms { get; set; }
        public House(string name, Room[] rooms)
        {
            Name = name;
            Rooms = rooms;
        }

    }
}
