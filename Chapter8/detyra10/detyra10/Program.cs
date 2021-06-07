﻿using System;

namespace detyra10
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = 0;

            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                decimalNumber += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine("Result is {0}.", decimalNumber);
        }
    }
}
