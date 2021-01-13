using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class HardDrive
    {
        public double totalStorage;
        public double availableStorage;
        public List<Applications> ApplicationsInHardDrive;

        public HardDrive(double totalStorage, double availableStorage)
        {
            this.ApplicationsInHardDrive = new List<Applications>();
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;
        }

        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            hardDrive.ApplicationsInHardDrive.Add(app);
        }
    }
}
