using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class Games : Applications
    {

        public Games()
        {
            applicationName = "Tetris";
            applicationType = "Game";
            requiredRAM = 3.0;
            requiredStorage = .23;
            requiredEffectiveMemory = .34;
        }
    }
}
