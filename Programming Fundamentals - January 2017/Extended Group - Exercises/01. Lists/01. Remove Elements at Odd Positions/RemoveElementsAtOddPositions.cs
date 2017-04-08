namespace _01.Remove_Elements_at_Odd_Positions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveElementsAtOddPositions
    {
        //// Write a program which reads a list of space-separated strings and removes 
        //// the elements at positions[1…3…5…7…etc.]. After that, print the elements 
        //// with no delimiter. Note that positions are counted from 1.

        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            List<string> evenPosition = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 1)
                {
                    evenPosition.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join("", evenPosition));
        }
    }
}