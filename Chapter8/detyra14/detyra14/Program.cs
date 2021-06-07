using System;

namespace detyra14
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = 0.000001M;
            decimal sum = 0M;

            for (int i = 0; i < 50000000; i++)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
