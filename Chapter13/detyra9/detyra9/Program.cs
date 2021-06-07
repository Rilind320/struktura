using System;

namespace detyra9
{
    class Program
    {

        static String encryptDecrypt(String inputString)
        {
            char xorKey = 'a';

            String outputString = "";

            int len = inputString.Length;

            for (int i = 0; i < len; i++)
            {
                outputString = outputString +
                char.ToString((char)(inputString[i] ^ xorKey));
            }

            Console.WriteLine(outputString);
            return outputString;
        }

        public static void Main(String[] args)
        {
            Console.Write("Enter a string: ");
            String sampleString = Console.ReadLine();

            Console.WriteLine("Encrypted String");
            String encryptedString = encryptDecrypt(sampleString);

            Console.WriteLine("Decrypted String");
            encryptDecrypt(encryptedString);
        }
    }
}
