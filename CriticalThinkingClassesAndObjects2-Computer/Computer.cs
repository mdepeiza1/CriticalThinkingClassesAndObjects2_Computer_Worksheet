using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class Computer
    {
        public CPU cpu;
        public GPU gpu;
        public HardDrive hardDrive;
        public RAM ram;
        public Games game;
        public TextEditor textEditor;
        public Motherboard motherboard;




        public Computer()
        {
            cpu = new CPU("Eon", "X50");
            gpu = new GPU("Trust", 7.0);
            hardDrive = new HardDrive(10.0, 6.0);
            ram = new RAM(20.0, "X");
            game = new Games();
            textEditor = new TextEditor();
            motherboard = new Motherboard("Speedy's", cpu, ram, hardDrive, gpu);
        }
    }
}
