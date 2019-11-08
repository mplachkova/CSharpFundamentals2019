using System;
using System.Collections.Generic;
using System.Linq;

namespace pokemonDontGo
{
    //You will receive a sequence of integers, separated by spaces.
    //Then you will begin receiving integers, which will correspond to indexes in that sequence.
    //When you receive an index, you must remove the element at that index from the sequence.
    //Main:
    // 1.You must increase the value of all elements in the sequence, which are less or equal to the removed element, with the value of the removed element.
    // 2.You must decrease the value of all elements in the sequence, which are greater than the removed element, with the value of the removed element.
    //Additionally:
    // 1. If the given index is less than 0, remove the first element of the sequence, and copy the last element to its place.
    // 2. If the given index is greater than the last index of the sequence, remove the last element from the sequence, and copy the first element to its place.
    //The increasing and decreasing of elements should be done in these cases, also. The element, whose value you should use is the removed element.
    //The program ends when the sequence has no elements.
    //When the program ends, you must print the summed value of all removed elements.
    class pokemonDontGo
    {
        static void Main(string[] args)
        {
            List<int> pokemonsInitial = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> removedElementsList = new List<int>();
            while (pokemonsInitial.Count != 0)
            {
                int indexToManipulate = int.Parse(Console.ReadLine());
                int currentCount = pokemonsInitial.Count;

                if (indexToManipulate < 0)
                {
                    int elementToInsert = pokemonsInitial[pokemonsInitial.Count - 1];
                    pokemonsInitial.Insert(1, elementToInsert); //Insert at 1 because 0 will be removed by the method
                    IncreaseDecreaseTheElements(pokemonsInitial, 0, removedElementsList);
                }
                else if (indexToManipulate > currentCount - 1)
                {
                    int elementToInsert = pokemonsInitial[0];
                    pokemonsInitial.Insert(pokemonsInitial.Count - 1, elementToInsert);
                    IncreaseDecreaseTheElements(pokemonsInitial, pokemonsInitial.Count - 1, removedElementsList);
                }
                else
                {
                    IncreaseDecreaseTheElements(pokemonsInitial, indexToManipulate, removedElementsList);
                }
            }
            Console.WriteLine(removedElementsList.Sum());
        }

        static void IncreaseDecreaseTheElements(List<int> pokemons, int index, List<int> removedElementsList)
        {
            int removedElement = pokemons[index];
            removedElementsList.Add(removedElement);
            pokemons.RemoveAt(index);

            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= removedElement)
                {
                    pokemons[i] += removedElement;
                }
                else
                {
                    pokemons[i] -= removedElement;
                }
            }
        }
    }
}