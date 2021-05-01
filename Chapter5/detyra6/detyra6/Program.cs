using System;

namespace detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter parameter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter parameter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter parameter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - (4 * a * c);

            if (discriminant == 0)
            {
                Console.Write("The quadratic equation has 1 real root and it is {0}", (-b / (2*a)));
            }
            else if (discriminant > 0)
            {
                double firstRoot = (-b + (Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)))) / (2 * a);
                double secondRoot = (-b - (Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)))) / (2 * a);
                Console.WriteLine("The quadratic equation has 2 real roots and they are {0} and {1}", firstRoot, secondRoot);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("The quadratic equation has no real roots");
            }
        }
    }
}
