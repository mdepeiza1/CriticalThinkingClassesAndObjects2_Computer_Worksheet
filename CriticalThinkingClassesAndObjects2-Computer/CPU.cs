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

        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if ((ram.totalGigabytes >= app.RequiredRAM)
                && (hardDrive.availableStorage >= app.RequiredStorage))
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
