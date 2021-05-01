using System;

namespace detyra4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 452;
            Console.WriteLine("The third bit of {0} is 1? {1}", number, ((number >> 3) & 1) == 1);
        }
    }
}
