using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three digit number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = number1 / 100;
            int number3 = number2 % 10;

            if (number3 == 7)
            {
                Console.WriteLine("Third digit of your number (right to left) is 7");
            }
            else
            {
                Console.WriteLine("Third digit of your number (right to left) is not 7");
            }
        }
    }
}
