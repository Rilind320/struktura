using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string sayHelloWorld = (string)helloWorld;
            Console.WriteLine(sayHelloWorld);
        }
    }
}
