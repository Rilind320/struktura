using System;

namespace detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit (0-9): ");
            byte digit = Convert.ToByte(Console.ReadLine());

            Console.Write("You chose number: ");

            switch (digit)
            {
                case 0:
                    Console.Write("Zero");
                    break;
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                case 5:
                    Console.Write("Five");
                    break;
                case 6:
                    Console.Write("Six");
                    break;
                case 7:
                    Console.Write("Seven");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine");
                    break;
                default:
                    Console.WriteLine("Please enter a valid digit!");
                    break;
            }
        }
    }
}
