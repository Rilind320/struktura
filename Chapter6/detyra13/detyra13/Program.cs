using System;

namespace detyra13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            Console.Write($"Decimal Value : {decimalValue} ");
        }
    }
}
