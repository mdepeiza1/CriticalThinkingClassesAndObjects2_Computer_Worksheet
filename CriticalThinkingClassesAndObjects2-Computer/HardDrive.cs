using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class HardDrive
    {
        double totalStorage;
        double availableStorage;

        public HardDrive(double totalStorage, double availableStorage)
        {
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;
        }
    }
}
