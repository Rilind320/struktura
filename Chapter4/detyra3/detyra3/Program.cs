using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of the company:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter address of the company:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter phone number of the company: ");
            uint phoneNumber = (uint)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fax number of the company: ");
            uint faxNumber = (uint)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter web page of the company: ");
            string webPage = Console.ReadLine();
            Console.WriteLine("Enter the manager name of the company: ");
            string manager = Console.ReadLine();

            Console.WriteLine("Enter manager's surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter manager's phone number: ");
            uint managersNumber = (uint)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Company name: {name}");
            Console.WriteLine($"Company address: {address}");
            Console.WriteLine($"Company phone number: {phoneNumber}");
            Console.WriteLine($"Company fax number: {faxNumber}");
            Console.WriteLine($"Company web page: {webPage}");
            Console.WriteLine($"Company manager: {manager}");
            Console.WriteLine($"Manager's personal info: {manager} {surname}, {managersNumber}");
        }
    }
}
