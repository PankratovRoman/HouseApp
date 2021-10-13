using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Electricity
{
    class AutomaticSwitcher : ElecricityDinModule
    {

        public int AmperCount { get; set; }
        public bool IsUZO { get; set; }
        public string WhatsOn { get; set; }

        

        public AutomaticSwitcher(string brand, int ampCount, bool isUzo, string whatsOn) : base (brand, 1)
        { 
            AmperCount = ampCount;
            IsUZO = isUzo;
            WhatsOn = whatsOn;
            IsOn = false;
        }

  

    }
}
