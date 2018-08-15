using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basics
{
    class Triangle:Shapes
    {
        public static double GetArea(double lengthOfBase, double height)
        {
            return lengthOfBase * height / 2;
        }

        public static double GetPerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }
    }
}
