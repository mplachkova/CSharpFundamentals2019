using System;
using System.Collections.Generic;
using System.Linq;

namespace nascar
{
    /*You are tasked with creating a program that outputs the results from the race.
    On the first line you will be given the names of the racers on their positions in the beginning of the race.
    On the next line, you will be given the following pairs {command} {racer}.
    You may receive the following types of commands:
    Race {racer} – add the pilot on the last position, if he isn’t in the race.
    Accident {racer} – remove the racer from the race.
    Box {racer} – move the racer one position back, if he is in the race and he is not already last.
    Overtake {racer} {racersCount} – move the racer the given count of positions forward, if he is in the race and the position is valid.
    Read commands until you receive “end”.
    At the end of the race, print the list with the names of the racers, separated by “~”.*/
    class nascar
    {
        static void Main(string[] args)
        {
            List<string> initialRacersList = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] instructions = command.Split();
                string action = instructions[0];
                string racerName = instructions[1];
                switch (action)
                {
                    case "Race":
                        if (!RacerParticipates(initialRacersList, racerName))
                        {
                            initialRacersList.Add(racerName);
                        }
                        break;
                    case "Accident":
                        initialRacersList.Remove(racerName);
                        break;
                    case "Box":
                        if (RacerParticipates(initialRacersList, racerName))
                        {
                            BoxTheRacer(initialRacersList, racerName);
                        }
                        break;
                    case "Overtake":
                        if (RacerParticipates(initialRacersList, racerName))
                        {
                            int movingCount = int.Parse(instructions[2]);
                            RacerOvertook(initialRacersList, racerName, movingCount);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ~ ", initialRacersList));
        }

        static bool RacerParticipates(List<string> racers, string racerName)
        {
            bool isInRace = false;
            if (racers.Contains(racerName))
            {
                isInRace = true;
            }
            return isInRace;
        }

        static void BoxTheRacer(List<string> racers, string racerName)
        {
            int index = racers.IndexOf(racerName);
            if (index < racers.Count - 1)
            {
                racers.RemoveAt(index);
                racers.Insert(index + 1, racerName);
            }
        }

        static void RacerOvertook(List<string> racers, string racerName, int movingCount)
        {
            int newPositionIndex = racers.IndexOf(racerName) - movingCount;
            if (newPositionIndex >= 0)
            {
                racers.RemoveAt(racers.IndexOf(racerName));
                racers.Insert(newPositionIndex, racerName);
            }
        }
    }
}