using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Heating
{

    class Pump
    {
        public string Brand { get; protected set; }
        public int Throughput { get; protected set; }
        public int Pressure { get; protected set; }
        public bool IsOn { get; set; }
        public Pump(string brand, int throughput, int pressure)
        {
            Brand = brand;
            Throughput = throughput;
            Pressure = pressure;
            IsOn = false;
        }
    }
}
