using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class TextEditor : Applications
    {
        public TextEditor()
        {
            applicationName = "Notepad";
            applicationType = "Text Editor";
            requiredRAM = 1.0;
            requiredStorage = .13;
            requiredEffectiveMemory = 0.0;
        }
    }
}
