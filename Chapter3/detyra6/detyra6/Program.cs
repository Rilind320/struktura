using System;

namespace detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a of a rectangle");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side b of a rectangle");
            double sideB = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * (sideA + sideB);

            double area = sideA * sideB;

            Console.WriteLine($"Perimeter of your rectangle is {perimeter}, while the area is {area}");
        }
    }
}
