using System;

namespace detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine($"{number} is EVEN");
            }
            else
            {
                Console.WriteLine($"{number} is ODD");
            }
        }
    }
}
