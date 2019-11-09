using System;
using System.Collections.Generic;
using System.Linq;

namespace listOperations
{
    class listOperations
    {
        //You will be given a list of integer numbers on the first line of input.
        //You will be receiving operations you have to apply on the list until you receive the "End" command.
        //Add {number} – add number at the end.1
        //Insert {number} {index} – insert number at given index.2
        //Remove {index} – remove at index.3
        //Shift left { count } – first number becomes last ‘count’ times.4
        //Shift right { count } – last number becomes first ‘count’ times.4
        //Note: there is a possibility that the given index is outside of the bounds of the array. In that case print "Invalid index".
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split()
                .ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        inputList.Add(command[1]);
                        break;
                    case "Insert":
                        int insetIindex = int.Parse(command[2]);
                        if (insetIindex >= 0 && insetIindex < inputList.Count)
                        {
                            inputList.Insert(int.Parse(command[2]), command[1]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(command[1]);
                        if (removeIndex >= 0 && removeIndex < inputList.Count)
                        {
                            inputList.RemoveAt(int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        int rotations = int.Parse(command[2]);
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < rotations; i++)
                            {
                                inputList.Add(inputList[0]);
                                inputList.RemoveAt(0);
                            }
                        }
                        else if (command[1] == "right")
                        {
                            for (int i = 0; i < rotations; i++)
                            {
                                inputList.Insert(0, inputList[inputList.Count - 1]);
                                inputList.RemoveAt(inputList.Count - 1);
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ",inputList));
        }
    }
}
