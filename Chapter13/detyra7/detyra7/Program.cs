using System;

namespace detyra7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text (20 characters maximum): ");
            string text = Console.ReadLine();

            if (text.Length > 20)
            {
                Console.WriteLine("The text can only be 20 characters long!");
            }
            else if (text.Length < 20)
            {
                for (int i = text.Length; i < 20; i++)
                {
                    text = text + "*";
                }
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine(text);
            }
        }
    }
}
