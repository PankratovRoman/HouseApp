using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Electricity
{
    abstract class ElecricityDinModule
    {
        public string Brand { get; set; }

        int cellsCount = 1;
        public bool IsOn { get; set; }
        virtual public int CellsCount { get { return cellsCount; } }

        public ElecricityDinModule(string brand, int cellsCount)
        {
            Brand = brand;
            this.cellsCount = cellsCount;
        }
        public void TurnOn() 
        {
            IsOn = !IsOn;
        }
    }
}
