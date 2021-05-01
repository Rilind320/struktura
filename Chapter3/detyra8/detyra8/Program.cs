using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter parameter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter parameter y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool validity = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(5, 2);

            if (validity == true)
            {
                Console.WriteLine("The point is inside the circle");
            }
            else
            {
                Console.WriteLine("The point is outside the circle");
            }
        }
    }
}
