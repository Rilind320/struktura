using System;

namespace detyra7
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
            Console.WriteLine("Enter a number: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int e = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine($"The greatest number is {a}");
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine($"The greatest number is {b}");
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine($"The greatest number is {c}");
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine($"The greatest number is {d}");
            }
            else if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine($"The greatest number is {e}"); 
            }
        }
    }
}
