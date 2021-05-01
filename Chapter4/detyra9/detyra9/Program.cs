using System;

namespace detyra9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("-------------------------");

            for (n = n; n > 0; n--)
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
