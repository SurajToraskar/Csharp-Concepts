﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interfaces
{
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Move();
        void Stop();
    }
}
