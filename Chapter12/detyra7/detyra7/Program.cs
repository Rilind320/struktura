﻿using System;

namespace detyra7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int n = -1;
            bool invalidNumber = false;

            try
            {
                n = Convert.ToInt32(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid number!");
                invalidNumber = true;
            }
            finally
            {
                if (n < 0)
                {
                    if (!invalidNumber) Console.WriteLine("Invalid number!");
                }
                else Console.WriteLine(Math.Sqrt(n));
            }

            Console.WriteLine("Good Bye");
        }
    }
}
