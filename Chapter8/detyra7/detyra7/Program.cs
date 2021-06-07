using System;

namespace detyra7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a hexadecimal value: ");
            string hex = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(hex, 16);
            Console.WriteLine($"{hex} in decimal is {decimalNumber}");
        }
    }
}
