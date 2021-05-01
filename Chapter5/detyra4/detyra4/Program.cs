using System;

namespace detyra4
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

            Console.WriteLine("The numbers given are {0}, {1}, {2}", a, b, c);
            Console.WriteLine("---------------------------------");
            Console.Write("Numbers after sorting in descending order are: ");

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0}, {1}, {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0}, {1}, {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", b, c, a);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("{0}, {1}, {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", c, b, a);
                }
            }
        }
    }
}
