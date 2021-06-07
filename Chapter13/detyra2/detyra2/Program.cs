using System;

namespace detyra2
{
    class Program
    {
        static string reverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter string for reverse: ");
            string someText = Console.ReadLine();

            Console.WriteLine($"{someText} reversed is {reverseString(someText)}");
        }
    }
}
