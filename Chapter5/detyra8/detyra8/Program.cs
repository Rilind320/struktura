using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 for string, 1 for integer or 2 for double: ");
            byte choice = Convert.ToByte(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Enter a string: ");
                    string userString = Console.ReadLine();
                    Console.WriteLine(userString + "*");
                    break;
                case 1:
                    Console.WriteLine("Enter an integer: ");
                    int userInteger = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(userInteger + 1);
                    break;
                case 2:
                    Console.WriteLine("Enter a double: ");
                    double userDouble = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(userDouble + 1);
                    break;
                default:
                    Console.WriteLine("Invalid case!");
                    break;
            }
        }
    }
}
