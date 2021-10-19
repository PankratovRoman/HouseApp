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

        public void BreatheLifeIntoTheHouse()
        {
            Console.WriteLine($"Welcome to The House! Type bla-bla-bla.... to breathe life into the house {Name}");
            Console.WriteLine();
        }

    }
}
