using System;

namespace detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a of trapezoid");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side b of trapezoid");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of trapezoid");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = (sideA + sideB) * height / 2;

            Console.WriteLine($"The area of your trapezoid is {area}");
        }
    }
}
