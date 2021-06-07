using System;

namespace detyra7
{
    public class Cat
    {
        private string name;
        private string color;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void SayMiau()
        {
            Console.WriteLine($"Cat {name} say: Miauuuuuu");
        }
    }

    public class Sequence
    {
        private static int currentValue = 0;

        private Sequence()
        {

        }

        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat someCat = new Cat();

            someCat.SayMiau();
            Console.WriteLine($"The color of cat {someCat.Name} is {someCat.Color}");

            Cat theCat = new Cat("Johnny", "brown");

            theCat.SayMiau();
            Console.WriteLine($"The color of cat {theCat.Name} is {theCat.Color}");

            Console.WriteLine($"Sequence[1...3]: {Sequence.NextValue()}, {Sequence.NextValue()}, {Sequence.NextValue()}");

        }
    }
}
