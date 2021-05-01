using System;

namespace detyra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine($"{number} is divisible by 5 and 7 without a remainder");
            }
            else if (number % 5 == 0 && number % 7 != 0)
            {
                Console.WriteLine($"{number} is divisible by 5 without a remainder, but not by 7");
            }
            else if (number % 5 != 0 && number % 7 == 0)
            {
                Console.WriteLine($"{number} is divisible by 7 without a remainder, but not by 5");
            }
            else
            {
                Console.WriteLine($"{number} is not divisible by 5 or 7 witout a remainder");
            }
        }
    }
}
