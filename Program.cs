using HouseApp.Engineering.Electricity;
using System;

namespace HouseApp
{
    class Program
    {
        static void Main()
        {
            Room MainRoom = new Room("MainRoom", 35.55f, "Big room for family and friends.");
            Room MasterBadroom = new Room("MasterBadroom", 12.91f, "Badroom for LORDS!");
            Room ChildBadroom = new Room("ChildBadroom", 13.23f, "Badroom for mini-LORDS!");
            Room GuestBedroom = new Room("GuestBedroom", 11.6f, "Badroom for non-LORDS!");
            Room Bathroom = new Room("Bathroom", 7.33f, "The most important room.");
            Room BoilerRoom = new Room("BoilerRoom", 6.7f, "Room for engineering systems.");
            Room Hall = new Room("Hall", 17.15f, "Just hall.");
            Room[] RoomsInHouse = new Room[] { MainRoom, MasterBadroom, ChildBadroom, GuestBedroom, Bathroom, BoilerRoom, Hall };
            House MyHouse = new House("RomJulHome", RoomsInHouse);

            AutomaticSwitcher firstAutomat = new AutomaticSwitcher("Shneider", 32, false, "Main input #1");
            AutomaticSwitcher secondAutomat = new AutomaticSwitcher("Shneider", 32, false, "Main input #2");
            AutomaticSwitcher thirdAutomat = new AutomaticSwitcher("Shneider", 32, false, "Main input #3");
            VoltageRelay firstRelay = new VoltageRelay("DigiTOP", 180, 250);
            VoltageRelay secondRelay = new VoltageRelay("DigiTOP", 180, 250);
            VoltageRelay thirdRelay = new VoltageRelay("DigiTOP", 180, 250);
            AutomaticSwitcher firstInSeconLine = new AutomaticSwitcher("Schneider", 25, true, "All bedrooms.");
            LightController proRelay = new LightController("EKF", true, 2);

            ElectricityPanel SuperShield = new ElectricityPanel(4, 18, BoilerRoom);

            SuperShield.Moduls[0, 0] = firstAutomat;
            SuperShield.Moduls[0, 1] = secondAutomat;
            SuperShield.Moduls[0, 3] = thirdAutomat;

            SuperShield.Moduls[0, 4] = firstRelay;
            SuperShield.Moduls[0, 7] = secondRelay;
            SuperShield.Moduls[0, 10] = thirdRelay;

            SuperShield.Moduls[1, 0] = firstInSeconLine;

            SuperShield.Moduls[2, 10] = proRelay;

            Console.WriteLine(proRelay.CellsCount + " " + proRelay.InputCount + " " + proRelay.OutputCount);

            //int rows = SuperShield.Moduls.GetUpperBound(0) + 1;
            //int columns = SuperShield.Moduls.Length / rows;
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (String.IsNullOrEmpty(SuperShield.Moduls[i, j].ToString())) { Console.WriteLine("*"); }
            //        else
            //        {
            //            Console.WriteLine($"{SuperShield.Moduls[i, j].Brand} hui \t");
            //        }

            //    }
            //}



        }
    }
}
