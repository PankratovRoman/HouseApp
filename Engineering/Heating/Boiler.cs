using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Heating
{
    class Boiler
    {
        public string Brand { get; protected set; }
        public int Power { get; protected set; }
        public string FuelSource { get; protected set; }
        public bool IsOn { get; set; }
        public Boiler(string brand, int power, string fuelSource)
        {
            Brand = brand;
            Power = power;
            FuelSource = fuelSource;
            IsOn = false;
        }
    }
}
