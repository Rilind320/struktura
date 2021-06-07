using System;

namespace detyra7
{
    class Program
    {
        public static string reverse(string number)
        {
            char[] stringNumber = number.ToCharArray();
            Array.Reverse(stringNumber);
            return new string(stringNumber);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();

            Console.WriteLine(reverse(number));
        }
    }
}
