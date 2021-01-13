using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class GPU
    {
        string manufacturer;
        double effectiveMemory;

        public GPU(string manufacturer, double effectiveMemory)
        {
            this.manufacturer = manufacturer;
            this.effectiveMemory = effectiveMemory;
        }
    }
}
