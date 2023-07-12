using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareArea = CalculateArea(5);
            Console.WriteLine("Area of square: " + squareArea);

            double rectangleArea = CalculateArea(4, 6);
            Console.WriteLine("Area of rectangle: " + rectangleArea);
        }

        static double CalculateArea(double sideLength)
        {
            // Calculate area of square
            double area = sideLength * sideLength;
            return area;
        }

        static double CalculateArea(double length, double width)
        {
            // Calculate area of rectangle
            double area = length * width;
            return area;
        }
    }

}
