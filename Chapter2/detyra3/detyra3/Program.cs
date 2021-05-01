
using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1 = 1.000001f;
            float number2 = 1.000001f;

            bool validity = (number1 - number2) <= 0.000001;

            Console.WriteLine(validity);
        }
    }
}
