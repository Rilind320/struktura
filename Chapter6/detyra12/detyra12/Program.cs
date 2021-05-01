using System;

namespace detyra12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number: ");
            int value = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(value, 2);

            Console.WriteLine("Your number in binary is " + binary);
        }
    }
}
