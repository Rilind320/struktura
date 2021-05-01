using System;

namespace detyra10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
