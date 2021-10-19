using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Electricity
{
    class LightController : ElecricityDinModule
    {
        readonly int inputCount = 4;
        readonly int outputCount = 4;
        int extensionCount;

        public bool HaveExtension { get; protected set; }
        public int ExtensionCount
        {
            get
            {
                return extensionCount;
            }
            protected set
            {
                extensionCount = value;
            }
        }
        public int InputCount
        {
            get
            {
                return inputCount; 
            }
        }
        public int OutputCount
        {
            get
            {
                return outputCount;
            }
        }

        public LightController(string brand, bool haveExt, int extCount) : base(brand, 5)
        {
            IsOn = false;
            HaveExtension = haveExt;
            if (extCount > 2 || extCount < 0)
            {
                throw new ArgumentException("Minimum/Maximum extensions = 0/2");
            }
            else
            {
                ExtensionCount = extCount;
            }

            if (HaveExtension)
            {
                CellsCount += (extensionCount * 2);
                inputCount += (extensionCount * inputCount);
                outputCount += (extensionCount * outputCount);
            }


        }




    }
}
