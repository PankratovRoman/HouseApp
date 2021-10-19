using HouseApp.Engineering.Electricity;
using HouseApp.Engineering.Heating;
using System;
using System.Text;

namespace HouseApp
{
    class Program
    {
        static void Main()
        {
            #region Build house
            Room MainRoom = new Room("MainRoom", 35.55f, "Big room for family and friends.");
            Room MasterBadroom = new Room("MasterBadroom", 12.91f, "Badroom for LORDS!");
            Room ChildBadroom = new Room("ChildBadroom", 13.23f, "Badroom for mini-LORDS!");
            Room GuestBedroom = new Room("GuestBedroom", 11.6f, "Badroom for non-LORDS!");
            Room Bathroom = new Room("Bathroom", 7.33f, "The most important room.");
            Room BoilerRoom = new Room("BoilerRoom", 6.7f, "Room for engineering systems.");
            Room Hall = new Room("Hall", 17.15f, "Just hall.");
            Room[] RoomsInHouse = new Room[] { MainRoom, MasterBadroom, ChildBadroom, GuestBedroom, Bathroom, BoilerRoom, Hall };
            House MyHouse = new House("RomJulHome", RoomsInHouse);
            MyHouse.BreatheLifeIntoTheHouse();
            #endregion

            #region Electricity system
            AutomaticSwitcher FirstAutomat = new AutomaticSwitcher("Shneider", 32, false, "Main input #1");
            AutomaticSwitcher SecondAutomat = new AutomaticSwitcher("Shneider", 32, false, "Main input #2");
            AutomaticSwitcher ThirdAutomat = new AutomaticSwitcher("Shneider", 32, false, "Main input #3");
            VoltageRelay FirstRelay = new VoltageRelay("DigiTOP", 180, 250);
            VoltageRelay SecondRelay = new VoltageRelay("DigiTOP", 180, 250);
            VoltageRelay ThirdRelay = new VoltageRelay("DigiTOP", 180, 250);
            AutomaticSwitcher FirstInSeconLine = new AutomaticSwitcher("Schneider", 25, true, "All bedrooms.");
            LightController ProRelay = new LightController("EKF", true, 2);

            ElectricityPanel SuperShield = new ElectricityPanel(4, 18, BoilerRoom);

            try
            {
                ElecricityDinModule.InstallOnShield(SuperShield, FirstAutomat, 0, 0);
                ElecricityDinModule.InstallOnShield(SuperShield, SecondAutomat, 0, 1);
                ElecricityDinModule.InstallOnShield(SuperShield, ThirdAutomat, 0, 2);
                ElecricityDinModule.InstallOnShield(SuperShield, FirstRelay, 0, 3);
                ElecricityDinModule.InstallOnShield(SuperShield, SecondRelay, 0, 6);
                ElecricityDinModule.InstallOnShield(SuperShield, ThirdRelay, 0, 9);
                ElecricityDinModule.InstallOnShield(SuperShield, FirstInSeconLine, 1, 0);
                ElecricityDinModule.InstallOnShield(SuperShield, ProRelay, 2, 0);

            }
            catch (InvalidOperationException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            #region Electricity panel check

            int rows = SuperShield.Modules.GetUpperBound(0) + 1;
            int columns = SuperShield.Modules.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{SuperShield.Modules[i, j]?.Brand ?? "*"} ");
                }
                Console.WriteLine();
            }

            #endregion
            #endregion

            #region Heating system

            Boiler Baxi = new Boiler("Baxi", 24, "gas");
            Collector Collector = new Collector("Stout", 9, true);
            Pump FloorPump = new Pump("Grundfos", 25, 40);
            HeatingSystem MainHeatingSystem = new HeatingSystem(Baxi);
            MainHeatingSystem.Collector.Add(Collector);
            MainHeatingSystem.Pump.Add(FloorPump);
            try
            {
                MainHeatingSystem.SwitchHeatingSystem();
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            Console.WriteLine();

            if (MainHeatingSystem.SystemStatusSwitch)
            {
                string collectors = "";
                string pumps = "";
                foreach (var i in Collector.Brand)
                {
                    collectors += i;
                }
                foreach (var i in FloorPump.Brand)
                {
                    pumps += i;
                }
                Console.WriteLine($"Boiler {Baxi.Brand} started. Collectors: {collectors} started. Pumps: {pumps} started.");
            }
            #endregion


        }
    }
}
