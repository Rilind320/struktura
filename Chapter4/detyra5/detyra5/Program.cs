using System;

namespace detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------");

            if (n < p)
            {
                for (int i = n; i <=p; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int o = p; o <= n; o++)
                {
                    if (o % 5 == 0)
                    {
                        Console.WriteLine(o);
                    }
                }
            }
        }
    }
}
