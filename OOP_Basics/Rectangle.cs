using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basics
{
    class Rectangle:Shapes
    {
        public static double GetArea(double side1, double side2)
        {
            if(side1 == side2)
            {
                Console.WriteLine("This is a square");
                return Math.Pow(side1, 2);
            }
            else
            {
                return side1 * side2;
            }
        }

        public static double GetPerimeter(double side1, double side2)
        {
            return 2 * (side1 + side2);
        }
    }
}
