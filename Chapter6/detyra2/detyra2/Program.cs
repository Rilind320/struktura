using System;

namespace detyra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------");

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 != 0 || i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
