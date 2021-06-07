using System;

namespace detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first side: ");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second side: ");
            int sideB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hypotenuse is: " + Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));
        }
    }
}
