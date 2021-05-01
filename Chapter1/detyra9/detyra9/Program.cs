using System;

namespace detyra9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int numberInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Square root of {numberInt} is " + Math.Sqrt(numberInt));
        }
    }
}
