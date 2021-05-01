using System;

namespace detyra13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int swapper = a;
            a = b;
            b = swapper;

            Console.WriteLine($"Variable a is {a}");
            Console.WriteLine($"Variable b is {b}");
        }
    }
}
