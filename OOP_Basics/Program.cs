using System;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            double areaOfCircle = circle.GetArea(4);
            Console.WriteLine(areaOfCircle);

            Console.ReadLine();
        }
    }
}
