using System;

namespace detyra2
{
    class Program
    {
        static void GetMax(int firstNum, int secondNum)
        {
            if(firstNum > secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int sNum = Convert.ToInt32(Console.ReadLine());

            GetMax(fNum, sNum);
        }
    }
}
