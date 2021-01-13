using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class Motherboard
    {
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GPU graphics;

        public Motherboard(string manufacturer, CPU processor, RAM temporaryMemory, 
            HardDrive storage, GPU graphics)
        {
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.temporaryMemory = temporaryMemory;
            this.storage = storage;
            this.graphics = graphics;
        }

        public void InstallApplication(Applications app)
        {
            if(processor.CheckRequirements(app, storage, temporaryMemory, graphics))
            {
                storage.ProcessInstall(app, storage, temporaryMemory);
            }
        }
    }
}
