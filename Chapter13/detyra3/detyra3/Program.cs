using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Console.Write("Enter arithmetic expression: ");
            string expression = Console.ReadLine();

            char[] stringArray = expression.ToCharArray();

            for (int i = 0; i < expression.Length; i++)
            {
                stringArray[i] = expression[i];
            }

            foreach (char character in stringArray)
            {
                if (character == '\u0028')
                {
                    counter += 1;
                }
                else if (character == '\u0029')
                {
                    counter -= 1;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Parenthesis are balanced");
            }
            else
            {
                Console.WriteLine("Parenthesis are not balanced");
            }
        }
    }
}
