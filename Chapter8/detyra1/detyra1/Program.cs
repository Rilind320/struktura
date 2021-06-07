using System;

namespace detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 151;
            int value2 = 35;
            int value3 = 43;
            int value4 = 251;
            int value5 = 1023;
            int value6 = 1024;

            string binary1 = Convert.ToString(value1, 2);
            string binary2 = Convert.ToString(value2, 2);
            string binary3 = Convert.ToString(value3, 2);
            string binary4 = Convert.ToString(value4, 2);
            string binary5 = Convert.ToString(value5, 2);
            string binary6 = Convert.ToString(value6, 2);

            Console.WriteLine(binary1);
            Console.WriteLine(binary2);
            Console.WriteLine(binary3);
            Console.WriteLine(binary4);
            Console.WriteLine(binary5);
            Console.WriteLine(binary6);
        }
    }
}
