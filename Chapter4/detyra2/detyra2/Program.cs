using System;

namespace detyra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Perimeter of your circle is {perimeter}, and area is {area}");
        }
    }
}
