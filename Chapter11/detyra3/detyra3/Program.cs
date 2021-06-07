using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.Write("Enter day: ");
            int day = Int32.Parse(Console.ReadLine());

            DateTime today = new DateTime(year, month, day);
            Console.WriteLine(today.ToString("ddddddddd"));
        }
    }
}
