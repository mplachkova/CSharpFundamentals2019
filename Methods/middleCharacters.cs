using System;

namespace middleCharacters
{
    class middleCharacters
    {
        static void Main(string[] args)
        {
            //You will receive a single string.Write a method that prints the middle character.
            //If the length of the string is even there are two middle characters.
            string inputString = Console.ReadLine();
            ReturnTheMiddleChar(inputString);
        }

        static void ReturnTheMiddleChar(string text)
        {
            int lengthOfInput = text.Length;
            int loopLength = lengthOfInput / 2;
            if (lengthOfInput % 2 != 0)
            {
                Console.WriteLine(text[loopLength]);
            }
            else
            {
                Console.WriteLine(text[loopLength - 1].ToString() + text[loopLength].ToString());
            }
        }
    }
}
