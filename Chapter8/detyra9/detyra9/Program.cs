using System;

namespace detyra9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary number: ");
            string binary = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(binary, 2);
            string hexNumber = decimalNumber.ToString("X");
            Console.WriteLine($"{binary} to hexadecimal is {hexNumber}");
        }
    }
}
