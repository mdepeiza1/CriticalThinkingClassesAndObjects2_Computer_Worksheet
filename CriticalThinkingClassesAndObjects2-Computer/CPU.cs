using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class CPU
    {
        public string manufacturer;
        public string name;

        public CPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;
        }

        public bool CheckRequirements(Applications app, HardDrive hardDrive, 
            RAM ram, GPU gpu)
        {
            if ((ram.totalGigabytes >= app.requiredRAM)
                && (hardDrive.availableStorage >= app.requiredStorage)
                && (gpu.effectiveMemory >= app.requiredEffectiveMemory))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
