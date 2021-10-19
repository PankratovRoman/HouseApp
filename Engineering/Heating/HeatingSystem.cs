using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Heating
{
    class HeatingSystem
    {
        public Boiler Boiler { get; protected set; }
        public List<Collector> Collector { get; protected set; }
        public List<Pump> Pump { get; protected set; }
        public HeatingSystem(Boiler boiler)
        {
            Boiler = boiler;
            Collector = new List<Collector>();
            Pump = new List<Pump>();
            SystemStatusSwitch = false;
        }
        public bool SystemStatusSwitch { get; protected set; }

        public void SwitchHeatingSystem()
        {
            Boiler.IsOn = !Boiler.IsOn;
            if (Collector.Count == 0)
            {
                throw new ArgumentException("There are no collectors, system start failed.");
            }
            if (Pump.Count == 0)
            {
                throw new ArgumentException("There are no pumps, system start failed.");
            }
            foreach (var i in Collector)
            {
                i.IsOn = !i.IsOn;
            }
            foreach (var i in Pump)
            {
                i.IsOn = !i.IsOn;
            }
            SystemStatusSwitch = !SystemStatusSwitch;
        }

    }
}
