using System;
using System.Collections.Generic;

namespace houseParty
{
    //Write a program that keeps track of guests, that are going to a house party.
    //On the first line of input, you are going to receive the number of commands you are going to receive.
    //On the next lines you are going to receive one of the following messages:
    //"{name} is going!"
    //"{name} is not going!"
    //If you receive the first message, you have to add the person if he/she is not in the list.
    //If he/she is in the list print on the console: "{name} is already in the list!".
    //If you receive the second message, you have to remove the person if he/she is in the list and if not print: "{name} is not in the list!".
    //At the end print all the guests.
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfcommands = int.Parse(Console.ReadLine());
            List<string> guestsList = new List<string>();
            for (int i = 0; i < numberOfcommands; i++)
            {
                string addRemoveGuest = Console.ReadLine();
                if (addRemoveGuest.Contains("is going"))
                {
                    AddGuestToList(addRemoveGuest, guestsList);
                }
                else if (addRemoveGuest.Contains("is not going"))
                {
                    RemoveGuestFromList(addRemoveGuest, guestsList);
                }
            }
            Console.WriteLine(string.Join("\n", guestsList));
        }

        static void RemoveGuestFromList(string guest, List<string> guestList)
        {
            string guestName = guest.Substring(0, guest.Length - 14);
            if (guestList.Contains(guestName))
            {
                guestList.Remove(guestName);
            }
            else
            {
                Console.WriteLine($"{guestName} is not in the list!");
            }
        }

        static void AddGuestToList(string guest, List<string> guestList)
        {
            string guestName = guest.Substring(0, guest.Length - 10);
            if (guestList.Contains(guestName))
            {
                Console.WriteLine($"{guestName} is already in the list!");
            }
            else
            {
                guestList.Add(guestName);
            }
        }
    }
}