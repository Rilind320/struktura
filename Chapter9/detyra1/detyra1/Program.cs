using System;

namespace detyra1
{
    class Program
    {
        static void sayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            sayHello(name);
        }
    }
}
