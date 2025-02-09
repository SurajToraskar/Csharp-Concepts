﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interfaces
{
    class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }
        public Vehicle(string brand="No Brand",int wheels=0,double speed=0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"{this.Brand} Moves Forward at {this.Speed} MPH");
        }
        public void Stop()
        {
            Console.WriteLine($"The {this.Brand} Stops");
            this.Speed = 0;
        }
    }
}
