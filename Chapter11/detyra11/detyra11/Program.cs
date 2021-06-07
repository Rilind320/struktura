using System;

namespace detyra11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] laudatoryPhrases = new string[]
            {
                "The product is excellent.",
                "This is a great product.",
                "I use this product constantly.",
                "This is the best product from this category."
            };
            string[] laudatoryStories = new string[]
            {
                "Now i feel better.",
                "I managed to change.",
                "It made some miracle.",
                "I can't believe it, but now I am feeling great.",
                "You should try it too, I am very satisfied."
            };
            string[] firstName = new string[]
            {
                "Dayan",
                "Stella",
                "Hellen",
                "Kate"
            };
            string[] lastName = new string[]
            {
                "Johnson",
                "Peterson",
                "Charls"
            };
            string[] cities = new string[]
            {
                "London",
                "Paris",
                "Berlin",
                "New York",
                "Madrid"
            };

            Console.WriteLine($"{laudatoryPhrases[random.Next(4)]} {laudatoryStories[random.Next(5)]} -- {firstName[random.Next(4)]} {lastName[random.Next(3)]}, {cities[random.Next(5)]}");
        }
    }
}
