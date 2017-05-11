namespace _07.Max_Sequence_of_Increasing_Elements
{
    using System;
    using System.Linq;
    public class MaxSequenceOfIncreasingElements
    {
        // Write a program that finds the longest increasing subsequence in an array of integers.
        // The longest increasing subsequence is a portion of the array (subsequence) that is strongly 
        // increasing and has the longest possible length. If several such subsequences exist, find the 
        // left most of them.
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var longestSeq = 0; // Allways will keep the longest sequence.
            var length = 1; // Will count how many times a number will repeat.
            var endIndex = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                var currentNum = input[i];
                var nextNum = input[i + 1];

                if (currentNum < nextNum)
                {
                    length++; 
                }
                else
                {
                    length = 1; // Start count new sequence.
                }

                if (longestSeq < length) 
                {
                    longestSeq = length; // If the current seq is > than the previous seq, it is the longest seq.
                    endIndex = i + 2;  
                }
            }

            for (int i = endIndex - longestSeq; i < endIndex; i++)
            {
                Console.Write("{0} ", input[i]);
            }
        }
    }
}
