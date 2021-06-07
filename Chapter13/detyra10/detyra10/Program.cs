using System;

namespace detyra10
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string[] textArray = text.Split(".");
            string keyword = " in ";

            int index;

            foreach (string sentence in textArray)
            {
                index = sentence.IndexOf(keyword);

                if (index != -1)
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
