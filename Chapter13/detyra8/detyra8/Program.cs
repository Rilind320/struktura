using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Test";
            char[] textArray = text.ToCharArray();

            foreach (char character in textArray)
            {
                Console.Write("\\u{0:x4}", (int)character);
            }
        }
    }
}
