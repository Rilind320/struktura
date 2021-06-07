using System;

namespace detyra10
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.Write("Enter numbers: ");
            string numbers = Console.ReadLine();
            string[] splitNumbers = numbers.Split(' ');

            for (int i = 0; i < splitNumbers.Length; i++)
            {
                result += Convert.ToInt32(splitNumbers[i]);
            }
            Console.WriteLine($"Reslut is {result}");
        }
    }
}
