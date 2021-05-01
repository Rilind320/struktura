using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestNumber = Int32.MaxValue;
            int largestNumber = Int32.MinValue;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }
            Console.WriteLine($"Smallest number is {smallestNumber}, largest number is {largestNumber}");
        }
    }
}
