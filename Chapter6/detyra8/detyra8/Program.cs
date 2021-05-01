using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter parameter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int nFactorial = 1;
            int sub = n + 1;
            int subFactorial = 1;
            int multi = 2 * n;
            int multiFactorial = 1;
            
            for (int i = 1; i <= n; i++)
            {
                nFactorial = nFactorial * i;
            }
            for (int o = 1; o <= sub; o++)
            {
                subFactorial = subFactorial * o;
            }
            for (int u = 1; u <= multi; u++)
            {
                multiFactorial = multiFactorial * u;
            }

            Console.WriteLine(multiFactorial / (subFactorial * nFactorial));
        }
    }
}
