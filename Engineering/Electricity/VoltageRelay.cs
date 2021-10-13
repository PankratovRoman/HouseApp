using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Electricity
{
    class VoltageRelay : ElecricityDinModule
    {

        public int MinVoltageCount { get; set; }
        public int MaxVoltageCount { get; set; }

        public VoltageRelay(string brand, int minVoltCount, int maxVoltCount) : base(brand, 3)
        {
            MinVoltageCount = minVoltCount;
            MaxVoltageCount = maxVoltCount;
            IsOn = false;
        }



    }
}
