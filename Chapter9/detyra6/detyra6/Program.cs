using System;

namespace detyra6
{
    class Program
    {
        static int number = int.MinValue;
        static void checker(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    number = array[i];
                    break;
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter {i} element of array: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            checker(arr);

            if (number == int.MinValue)
                Console.WriteLine("-1");
            else
                Console.WriteLine($"{number} is greater than its neighbours");
        }
    }
}
