using System;

namespace detyra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int negativeNumers = 0;

            if (firstNumber < 0)
            {
                negativeNumers++;
            }

            if (secondNumber < 0)
            {
                negativeNumers++;
            }

            if(thirdNumber < 0)
            {
                negativeNumers++;
            }

            if (negativeNumers % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
