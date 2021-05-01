using System;

namespace detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            bool isMale = true;
            if (isMale == true)
            {
                Console.WriteLine($"{name} is a male");
            }
            else
            {
                Console.WriteLine($"{name} is a female");
            }
        }
    }
}
