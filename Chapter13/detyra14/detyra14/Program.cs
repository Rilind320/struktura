using System;

namespace detyra14
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++ and PHP is not Delphi";
            string[] words = text.Split(' ');
            Array.Reverse(words);
            string reverseText = String.Join(" ", words);

            Console.WriteLine(text);
            Console.WriteLine(reverseText);
        }
    }
}
