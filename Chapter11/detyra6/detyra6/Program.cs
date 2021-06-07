using System;

namespace detyra6
{
    class Program
    {

        static void threeSides(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine($"Area of the triangle by three sides given is: {area}");
        }

        static void sideHeight(double sideA, double height)
        {
            double area = (sideA * height) / 2;
            Console.WriteLine($"Area of the triangle by one side and height given is: {area}");
        }

        static void sidesAngle(double sideA, double sideB, double angle)
        {
            double area = (sideA * sideB * Math.Sin(angle)) / 2;
            Console.WriteLine($"Area of the triangle by two sides and the angle between them is {area}");
        }
        static void Main(string[] args)
        {
            Console.Write("First side: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second side: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Third side: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter angle between 2 sides (in degrees): ");
            double d = Convert.ToDouble(Console.ReadLine());

            threeSides(a, b, c);
            sideHeight(a, h);
            sidesAngle(a, b, d);
        }
    }
}
