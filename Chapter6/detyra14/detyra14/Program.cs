using System;

namespace detyra14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number: ");
            int decValue = Convert.ToInt32(Console.ReadLine());
            string hexvalue = decValue.ToString("X");

            Console.WriteLine("Your number in hex is " + hexvalue);
        }
    }
}
