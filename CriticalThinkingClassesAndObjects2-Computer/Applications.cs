using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    public abstract class Applications
    {
        public string applicationName;
        public string applicationType;
        public double requiredRAM;
        public double requiredStorage;
        public double requiredEffectiveMemory; //was this the right implementation?
        
        public Applications()
        {
            applicationName = "Slack";
            applicationType = "Messaging Service";
            requiredRAM = 4.0; //In Gigabytes
            requiredStorage = .512; // In Gigabytes
            requiredEffectiveMemory = 0.0; //was this the right implementation?
        }
    }
}
