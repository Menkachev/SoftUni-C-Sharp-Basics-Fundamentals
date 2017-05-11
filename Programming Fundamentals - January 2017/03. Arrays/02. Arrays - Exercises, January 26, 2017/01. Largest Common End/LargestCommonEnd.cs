namespace _01.Largest_Common_End
{
    using System;
    using System.Linq;

    class LargestCommonEnd
    {
        // Read two arrays of words and find the length of the largest common end (left or right).

        // Examples: Input: hi php java csharp sql html css js         -> Output: 3
        //                  hi php java js softuni nakov java learn

        // Comments: The largest common end is at the left: hi php java.

        static void Main()
        {
            var firstLine = Console.ReadLine().Split().ToArray();
            var secondLine = Console.ReadLine().Split().ToArray();

            var leftSeq = 0; // Will count the equals from left.
            var rightSeq = 0; // Will count the equals from right.

            var firstLength = firstLine.Length;
            var secondLength = secondLine.Length;

            var minLength = Math.Min(firstLength, secondLength); // Find the shorter input.

            // Left sequence.
            for (int i = 0; i < minLength; i++)
            {
                if (firstLine[i] == secondLine[i])
                {
                    leftSeq++;
                }
                else
                {
                    break;
                }
            }

            // Right sequence.
            for (int i = firstLength - 1, j = secondLength - 1; Math.Min(i, j) >= 0; i--, j--)
            {
                if (firstLine[i] == secondLine[j])
                {
                    rightSeq++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(leftSeq, rightSeq));
        }
    }
}