using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Heating
{
    class Collector
    {
        public string Brand { get; protected set; }
        public int OutputCount { get; protected set; }
        public bool HaveAdjuster { get; protected set; }
        public bool IsOn { get; set; }
        public Collector(string brand, int outputCount, bool haveAdjuster)
        {
            Brand = brand;
            OutputCount = outputCount;
            HaveAdjuster = haveAdjuster;
            IsOn = false;
        }


    }
}
