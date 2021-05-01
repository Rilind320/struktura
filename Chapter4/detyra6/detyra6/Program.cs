using System;

namespace detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"First number is {firstNumber}, second number is {secondNumber}");
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine($"{secondNumber} is greater than {firstNumber}");
            }
        }
    }
}
