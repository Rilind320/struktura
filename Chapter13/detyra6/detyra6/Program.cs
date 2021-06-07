using System;

namespace detyra6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else.";
            string firstUpcase = text.Substring(19, 16);
            string secondUpcase = text.Substring(51, 8);

            Console.WriteLine("We are living in a " + firstUpcase.ToUpper() + ". We don't have " + secondUpcase.ToUpper() + " else.");
        }
    }
}
