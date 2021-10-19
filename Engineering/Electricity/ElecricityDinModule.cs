using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Electricity
{
    abstract class ElecricityDinModule
    {
        public string Brand { get; set; }

        protected int cellsCount;
        public bool IsOn { get; set; }
        public int CellsCount { get { return cellsCount; } protected set { cellsCount = value; } }

        protected ElecricityDinModule(string brand, int cellsCount)
        {
            Brand = brand;
            CellsCount = cellsCount;
        }
        public void TurnOn()
        {
            IsOn = !IsOn;
        }

        public static void InstallOnShield(ElectricityPanel shield, ElecricityDinModule dinModule, int rowOnShiled, int cellOnRow)
        {
            if (shield.Modules.GetUpperBound(1) < cellOnRow + dinModule.cellsCount)
            {
                throw new InvalidOperationException($"Not enough slots for {dinModule.Brand}.");
            }
            for (var i = cellOnRow; i < cellOnRow + dinModule.cellsCount; i++) //0 11
            {
                if (shield.Modules[rowOnShiled, i] != null)
                {
                    throw new InvalidOperationException($"There are no empty slots for {dinModule.Brand}.");
                }
            }
            for (var i = cellOnRow; i < cellOnRow + dinModule.cellsCount; i++)
            {
                shield.Modules[rowOnShiled, i] = dinModule;
            }
        }
    }
}
