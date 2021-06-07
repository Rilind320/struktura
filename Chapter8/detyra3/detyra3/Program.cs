using System;

namespace detyra3
{
    class Program
    {   
        static void Main(string[] args)
        {
            string[] values = { "2A3E", "FA", "FFFF", "5A0E9" };

            foreach(string value in values)
            {
                Console.WriteLine("{0} in decimal is {1}", value, Convert.ToInt32(value, 16));
            }
            Console.WriteLine("-------------------------------------");
            foreach(string value in values )
            {
                Console.WriteLine("{0} in binary is {1}", value, Convert.ToString(Convert.ToInt32(value, 16), 2));
            }
        }
    }
}
