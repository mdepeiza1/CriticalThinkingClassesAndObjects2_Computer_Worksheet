﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingClassesAndObjects2_Computer
{
    class RAM
    {
        public double totalGigabytes;
        public string brand;

        public RAM(double totalGigabytes, string brand)
        {
            this.totalGigabytes = totalGigabytes;
            this.brand = brand;
        }
    }
}
