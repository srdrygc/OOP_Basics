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
    }
}
