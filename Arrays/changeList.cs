using System;
using System.Collections.Generic;
using System.Linq;

namespace changeList
{
    class changeList
    {
        //Write a program, which reads a list of integers from the console and receives commands and manipulate the list.
        //Your program may receive the following commands:
        //Delete { element} – delete all elements in the array, which are equal to the given element.
        //Insert { element} { position} – insert an element and the given position.
        //You should stop the program when you receive the command "end".Print the numbers in the array separated by a single whitespace.
        static void Main(string[] args)
        {
            List<string> input = Console
                .ReadLine()
                .Split()
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] instructions = command.Split();
                if (instructions[0] == "Delete")
                {
                    string elementToRemove = instructions[1];
                    input.RemoveAll(element => element == elementToRemove);
                }
                else if (instructions[0] == "Insert")
                {
                    int index = int.Parse(instructions[2]);
                    input.Insert(index, instructions[1]);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
