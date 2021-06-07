using System;

namespace detyra4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);
            Console.WriteLine($"{number} in binary is {binaryNumber}");
        }
    }
}
