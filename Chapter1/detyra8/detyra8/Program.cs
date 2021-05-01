using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = DateTime.UtcNow.ToString("D");
            string time = DateTime.UtcNow.ToString("T");
            Console.WriteLine(date + " " + time);
        }
    }
}
