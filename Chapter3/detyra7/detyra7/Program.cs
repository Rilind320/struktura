using System;

namespace detyra7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight (in kilograms)");
            double weight = Convert.ToDouble(Console.ReadLine());
            double weightPound = weight * 2.205;

            double moonWeight = weight * 0.17;
            double moonWeightPound = weightPound * 0.17;

            Console.WriteLine($"If on Earth you weight {weight}kg ({weightPound}lbs), on Moon you would be {moonWeight}kg ({moonWeightPound}lbs)");
        }
    }
}
