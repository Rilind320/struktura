using System;

namespace detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine($"First number is {firstNumber}, second number is {secondNumber}, third number is {thirdNumber}, and the sum of all three numbers is {sum}");
        }
    }
}
