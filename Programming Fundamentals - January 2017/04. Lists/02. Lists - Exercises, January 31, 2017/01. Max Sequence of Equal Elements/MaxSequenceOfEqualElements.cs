namespace _01.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        //// Read a list of integers and find the longest sequence of equal elements.
        //// If several exist, print the leftmost.

        //// Example: Input: 3 4 4 5 5 5 2 2 -> Output: 5 5 5

        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var longestSequence = new List<int>();
            var currentSequence = new List<int>();

            currentSequence.Add(numbers[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == currentSequence[0])
                {
                    currentSequence.Add(numbers[i]);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>();

                        for (int j = 0; j < currentSequence.Count; j++)
                        {
                            longestSequence.Add(currentSequence[j]);
                        }
                    }

                    currentSequence = new List<int>();
                    currentSequence.Add(numbers[i]);
                }
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>();

                for (int j = 0; j < currentSequence.Count; j++)
                {
                    longestSequence.Add(currentSequence[j]);
                }
            }

            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}