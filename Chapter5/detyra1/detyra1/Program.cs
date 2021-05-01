
using System;

namespace detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int swapper;
            Console.WriteLine($"Variable a is {a}, variable b is {b}");
            Console.WriteLine("-------------------------------------");

            if (a > b)
            {
                swapper = a;
                a = b;
                b = swapper;
            }
            Console.WriteLine($"Variable a is {a}, variable b is {b}");
        }
    }
}
