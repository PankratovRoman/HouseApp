using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp
{
    class Room
    {
        public string Name { get; set; }
        public float Square { get; set; }
        public string Destination { get; set; }

        public Room(string name, float square, string dest)
        {
            Name = name;
            Square = square;
            Destination = dest;
        }
    }
}
