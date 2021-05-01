using System;

namespace detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFactorial = 1;
            int kFactorial = 1;
            Console.WriteLine("Enter parameter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter parameter k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            
            if (1 < k && k < n)
            {
                for (int i = 1; i <= n; i++)
                {
                    nFactorial = nFactorial * i;
                }
                for (int o = 1; o <= k; o++)
                {
                    kFactorial = kFactorial * o;
                }
                Console.WriteLine(nFactorial / kFactorial);
            }
        }
    }
}
