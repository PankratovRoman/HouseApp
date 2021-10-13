using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Engineering.Electricity
{
    class LightController : ElecricityDinModule
    {
        int cellsCount = 5;
        int inputCount = 4;
        int outputCount = 4;
        int extensionCount;
        
        public bool HaveExtension { get; set; }
        public int ExtensionCount
        {
            get
            {
                if (HaveExtension)
                {
                    return extensionCount;
                }
                else
                {
                    throw new Exception("There is no extensions");
                }
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
                if (HaveExtension)
                {
                    return inputCount += (extensionCount * inputCount);
                }
                else
                {
                    return inputCount;
                }
            }
        }
        public int OutputCount
        {
            get
            {
                if (HaveExtension)
                {
                    return outputCount += (extensionCount * outputCount);
                }
                else
                {
                    return outputCount;
                }
            }
        }

        public override int CellsCount
        {
            get
            {
                if (HaveExtension)
                {
                    return cellsCount += (extensionCount * 3);
                }
                else
                {
                    return cellsCount;
                }
            }
        }

        public LightController(string brand, bool haveExt, int extCount) : base (brand, 5)
        {
            IsOn = false;
            HaveExtension = haveExt;
            if (extCount > 2 || extCount < 0)
            {
                throw new Exception("Minimum/Maximum extensions = 0/2");
            }
            else
            {
                ExtensionCount = extCount;
            }

        }

  


    }
}
