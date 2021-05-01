
using System;

namespace detyra10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four digit number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int fourthDigit = userNumber % 10;
            int thirdDigit = (userNumber / 10) % 10;
            int secondDigit = (userNumber / 100) % 10;
            int firstDigit = (userNumber / 1000) % 10;

            Console.WriteLine($"The given number is {userNumber}");
            Console.WriteLine("The sum of all digits is {0}", (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine($"The number in reverse is {fourthDigit}{thirdDigit}{secondDigit}{firstDigit}");
            Console.WriteLine($"The last digit in the first place {fourthDigit}{firstDigit}{secondDigit}{thirdDigit}");
            Console.WriteLine($"Exchange sencond and third digits {firstDigit}{thirdDigit}{secondDigit}{fourthDigit}");
        }
    }
}
