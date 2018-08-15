using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basics
{
    class Circle:Shapes
    {
        public double GetPerimeter(double r)
        {
            return 2 * Math.PI * r;
        }
        public double GetArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
