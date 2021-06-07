using System;

namespace detyra4
{
    class Program
    {
        static void Main(string[] args)
        {
            int startTime = Environment.TickCount;
            int seconds = startTime / 1000;
            int minutes = seconds / 60;
            int hours = minutes / 60;
            int days = hours / 24;
            Console.WriteLine(startTime);
            Console.WriteLine($"{days}days, {hours}hours, {minutes}minutes and {seconds}seconds");
        }
    }
}
