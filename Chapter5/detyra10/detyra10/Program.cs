using System;

namespace detyra10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your points (1-9): ");
            int points = Convert.ToInt32(Console.ReadLine());

            switch (points)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your final points are {0}", (points * 10));
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Your final points are {0}", (points * 100));
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Your final points are {0}", (points * 1000));
                    break;
                default:
                    Console.WriteLine("Invalid points!");
                    break;
            }
        }
    }
}
