﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AbstractClassesAndMethods
{
     class Rectangle:Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length,double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Length is {Length} and Width is {Width}");
        }
    }
}
