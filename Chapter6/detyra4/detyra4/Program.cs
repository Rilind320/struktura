using System;

namespace detyra4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int s = 1; s <= 13; s++)
            {
                if (s == 13)
                {
                    Console.WriteLine("A of spades");
                }
                else if (s == 12)
                {
                    Console.WriteLine("K of spades");
                }
                else if (s == 11)
                {
                    Console.WriteLine("Q of spades");
                }
                else if (s == 10)
                {
                    Console.WriteLine("J of spades");
                }
                else
                {
                    Console.WriteLine((s + 1) + " of spades");
                }
            }

            Console.WriteLine("------------------------------------");

            for (int c = 1; c <= 13; c++)
            {
                if (c == 13)
                {
                    Console.WriteLine("A of clubs");
                }
                else if (c == 12)
                {
                    Console.WriteLine("K of clubs");
                }
                else if (c == 11)
                {
                    Console.WriteLine("Q of clubs");
                }
                else if (c == 10)
                {
                    Console.WriteLine("J of clubs");
                }
                else
                {
                    Console.WriteLine((c + 1) + " of clubs");
                }
            }

            Console.WriteLine("------------------------------------");

            for (int h = 1; h <= 13; h++)
            {
                if (h == 13)
                {
                    Console.WriteLine("A of hearts");
                }
                else if (h == 12)
                {
                    Console.WriteLine("K of hearts");
                }
                else if (h == 11)
                {
                    Console.WriteLine("Q of hearts");
                }
                else if (h == 10)
                {
                    Console.WriteLine("J of hearts");
                }
                else
                {
                    Console.WriteLine((h + 1) + " of hearts");
                }
            }

            Console.WriteLine("------------------------------------");

            for (int d = 1; d <= 13; d++)
            {
                if (d == 13)
                {
                    Console.WriteLine("A of diamonds");
                }
                else if (d == 12)
                {
                    Console.WriteLine("K of diamonds");
                }
                else if (d == 11)
                {
                    Console.WriteLine("Q of diamonds");
                }
                else if (d == 10)
                {
                    Console.WriteLine("J of diamonds");
                }
                else
                {
                    Console.WriteLine((d + 1) + " of diamonds");
                }
            }
        }
    }
}
