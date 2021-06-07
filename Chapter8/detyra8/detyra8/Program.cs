using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a hexadecimal value: ");
            string hex = Console.ReadLine();
            string binaryNumber = Convert.ToString(Convert.ToInt64(hex, 16), 2);
            Console.WriteLine($"{hex} in binary is {binaryNumber}");
        }
    }
}
