using System;

namespace detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary number: ");
            string binary = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(binary, 2);
            Console.WriteLine($"{binary} in decimal is {decimalNumber}");
        }
    }
}
