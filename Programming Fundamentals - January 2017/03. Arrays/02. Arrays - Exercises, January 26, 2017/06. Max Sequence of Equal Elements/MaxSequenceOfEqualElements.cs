namespace _06.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;
    public class MaxSequenceOfEqualElements
    {
        // Write a program that finds the longest sequence of equal elements in an array of integers.
        // If several longest sequences exist, print the leftmost one.
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var longestSeq = 0; // Allways will keep the longest sequence.
            var length = 1; // Will count how many times a number will repeat.
            var repeatedNum = 0; // The real number.

            for (int i = 0; i < input.Length - 1; i++)
            {
                var currentNum = input[i];
                var nextNum = input[i + 1];

                if (currentNum == nextNum)
                {
                    length++;
                }
                else
                {
                    length = 1; // Start count new sequence.
                }

                if (length > longestSeq)
                {
                    longestSeq = length; // If the current seq is > than the previous seq, it is the longest seq.
                    repeatedNum = currentNum; // Repeated num is the current num - input[i].
                }
            }

            for (int i = 0; i < longestSeq; i++)
            {
                Console.Write("{0} ", repeatedNum);
            }
        }
    }
}
