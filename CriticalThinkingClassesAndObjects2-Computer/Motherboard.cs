using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class Motherboard
    {
        string manufacturer;
        CPU processor;
        RAM temporaryMemory;
        HardDrive storage;
        GPU graphics;

        public Motherboard(string manufacturer, CPU processor, RAM temporaryMemory, 
            HardDrive storage, GPU graphics)
        {
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.temporaryMemory = temporaryMemory;
            this.storage = storage;
            this.graphics = graphics;
        }


    }
}
