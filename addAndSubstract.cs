using System;

namespace addAndSubstract
{
    class addAndSubstract
    {
        static void Main(string[] args)
        {
            //You will receive 3 integers.
            //Write a method Sum to get the sum of the first two integers
            //and Subtract method that subtracts the third integer from the result from the Sum method.

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sum = GiveMeTheSum(firstNum, secondNum);
            GiveMeTheSubstractionResult(sum, thirdNum);
        }

        static int GiveMeTheSum(int firstNum, int secondNum)
        {
            return (firstNum + secondNum);
        }

        static void GiveMeTheSubstractionResult(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }
    }
}
