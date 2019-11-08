using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a sequence of numbers and a special bomb number with a certain power.
//Your task is to detonate every occurrence of the special bomb number and according to its power - his neighbors from left and right.
//Detonations are performed from left to right and all detonated numbers disappear.
//Finally print the sum of the remaining elements in the sequence.
namespace bombNumber
{
    class bombNumber
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] instructions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNumber = instructions[0];
            int specialNumPower = instructions[1];

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == specialNumber)
                {
                    int specialIndex = inputList.IndexOf(specialNumber);
                    int start = Math.Max(0, specialIndex - specialNumPower); //Assures the loop starts at 0;
                    int end = Math.Min(inputList.Count - 1, specialIndex + specialNumPower); // Assures the loop stops at then of the List;
                    for (int j = start; j <= end; j++)
                    {
                        inputList[j] = 0;
                    }
                }
            }
            Console.WriteLine(inputList.Sum());
        }
    }
}