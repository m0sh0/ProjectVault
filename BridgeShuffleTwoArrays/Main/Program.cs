using System;
using System.Collections.Generic;
using System.Linq;

/*
C, C, C, C
D

A, A, A, A
B, B, B, B
 */
namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> array1 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> array2 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> shuffledArray = BridgeShuffle(array1, array2);

            Console.WriteLine($"Bridge shuffled array: {string.Join(", ", shuffledArray)}");
        }

        private static List<string> BridgeShuffle(List<string> array1, List<string> array2)
        {
            List<string> shuffledArray = new();

            int range = Math.Max(array1.Count, array2.Count);

            for (int i = 0; i < range; i++)
            {
                if (array1.Count > i)
                {
                    shuffledArray.Add(array1[i]);
                }

                if (array2.Count > i)
                {
                    shuffledArray.Add(array2[i]);
                }
            }

            return shuffledArray;
        }
    }
}
