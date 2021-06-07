using System;

namespace detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string keyword = "in";

            int index = text.IndexOf(keyword);

            int counter = 0;

            while (index != -1)
            {
                Console.WriteLine($"{keyword} found at index {index}");
                index = text.IndexOf(keyword, index + 1);
                counter += 1;
            }
            Console.WriteLine($"Substring {keyword} was found {counter} times");
        }
    }
}
