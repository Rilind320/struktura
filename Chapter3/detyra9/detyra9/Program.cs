using System;

namespace detyra9
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
                if (x <= -1)
                {
                    Console.WriteLine("The point is inside the circle, but outside the rectangle");
                }
                else
                {
                    Console.WriteLine("The point is inside the circle and inside the rectangle");
                }
            }
            else
            {
                Console.WriteLine("The point is outside the circle");
            }
        }
    }
}
