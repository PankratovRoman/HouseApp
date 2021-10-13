using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Electricity
{
    class ElectricityPanel
    {
        public int RowCount { get; set; }
        public int CellsInRow { get; set; }
        public ElecricityDinModule[,] Moduls { get { return new ElecricityDinModule[RowCount, CellsInRow]; } }
        public Room InstallationPlace { get; }
        public ElectricityPanel(int rowCount, int cellsInRow, Room installPlace)
        {
            RowCount = rowCount;
            CellsInRow = cellsInRow;
            InstallationPlace = installPlace;
        }
    }
}
