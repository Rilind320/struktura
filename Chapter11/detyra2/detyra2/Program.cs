using System;

namespace detyra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
                Console.WriteLine(rand.Next(100, 201));
        }
    }
}
