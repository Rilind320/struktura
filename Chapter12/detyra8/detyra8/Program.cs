using System;

namespace detyra8
{
    class Program
    {

        static void ReadNumber(int start, int end, int number)
        {
            try
            {
                
            }
            finally
            {
                if (number < start || number > end)
                {
                    Console.WriteLine("Number is not in the range!");
                }
                else
                {
                    Console.WriteLine($"{number} is a valid number.");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter starting point: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ending point: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter number in range {start}-{end}: ");
            int number = Convert.ToInt32(Console.ReadLine());

            ReadNumber(start, end, number);
        }
    }
}
