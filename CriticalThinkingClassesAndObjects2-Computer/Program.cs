using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();

            computer.motherboard.InstallApplication(computer.game);
            computer.motherboard.InstallApplication(computer.textEditor);
        }
    }
}
