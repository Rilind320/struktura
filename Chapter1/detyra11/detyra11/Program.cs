using System;

namespace detyra11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            int ageToInt = Convert.ToInt32(age);
            Console.WriteLine("After 10 years you will be " + (ageToInt + 10));
        }
    }
}
