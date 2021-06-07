using System;
using System.Linq;

namespace detyra11
{
    class Program
    {
        static void Main(string[] args)
        {
            string forbiden = "C#,CLR,Microsoft";
            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
            string[] forbidenWords = forbiden.Split(",");
            string replacement = "*";

            Console.WriteLine(text);

            foreach (string word in forbidenWords)
            {
                int wordLength = word.Length;
                text = text.Replace(word, String.Concat(Enumerable.Repeat(replacement, wordLength)));
            }
            Console.WriteLine(text);
        }
    }
}
