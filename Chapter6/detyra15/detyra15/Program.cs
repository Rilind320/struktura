﻿using System;

namespace detyra15
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex_value = "FF";

            int int_value = Convert.ToInt32(hex_value, 16);

            Console.WriteLine("hex_value = {0}", hex_value);
            Console.WriteLine("int_value = {0}", int_value);
        }
    }
}
