using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"{a} is the greatest number");
                }
                else
                {
                    Console.WriteLine($"{c} is the greatest number");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine($"{b} is the greatest number");
                }
                else
                {
                    Console.WriteLine($"{c} is the greatest number");
                }
            }
        }
    }
}
