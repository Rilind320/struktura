using System;

namespace detyra12
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Rilind";
            string lastName = "Idrizi";
            byte age = 18;
            char gender = '\u004D';
            uint uniqueNumber = 27560001;
            Console.WriteLine($"{firstName} {lastName}, {age} years old, gender {gender}, serial number {uniqueNumber}");
        }
    }
}
