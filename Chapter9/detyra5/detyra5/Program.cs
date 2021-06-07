using System;

namespace detyra5
{
    class Program
    {
        static void checker(int position, int[] array)
        {
            if (position > array[position + 1] && position > array[position - 1])
            {
                Console.WriteLine($"The number located in position {position}, is greater than its two neighbours.");
            }
            else
            {
                Console.WriteLine($"The number located in position {position}, is not greater than its two neighbours.");
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i} element of array: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter position: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            checker(pos, arr);
        }
    }
}
