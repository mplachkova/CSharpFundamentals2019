using System;
using System.Linq;

namespace encriptSortPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a sequence of strings from the console. Encrypt every string by summing:
            //The code of each vowel multiplied by the string length
            //The code of each consonant divided by the string length
            //Sort the number sequence in ascending order and print it on the console.
            //On first line, you will always receive the number of strings you have to read.

            int stringsNumber = int.Parse(Console.ReadLine());
            int[] result = new int[stringsNumber];

            for (int i = 0; i < stringsNumber; i++)
            {
                string input = Console.ReadLine();
                int length = input.Length;
                int charCode = 0;
                int vowelMultiplied = 0;
                int consonantDivided = 0;
                int encriptedValue = 0;

                for (int j = 0; j < length; j++)
                {
                    bool lowerCaseVowel = input[j] == 'a' || input[j] == 'e' || input[j] == 'i' || input[j] == 'o' || input[j] == 'u';
                    bool upperCaseVowel = input[j] == 'A' || input[j] == 'E' || input[j] == 'I' || input[j] == 'O' || input[j] == 'U';

                    if (lowerCaseVowel || upperCaseVowel)
                    {
                        charCode = input[j];
                        vowelMultiplied = charCode * length;
                        encriptedValue += vowelMultiplied;
                    }
                    else
                    {
                        charCode = input[j];
                        consonantDivided = charCode / length;
                        encriptedValue += consonantDivided;
                    }
                }
                result[i] = encriptedValue;
            }
            Array.Sort(result);
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
