using System;

namespace detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string hexNumber = number.ToString("X");
            Console.WriteLine($"{number} in hexadecimal is {hexNumber}");
        }
    }
}
