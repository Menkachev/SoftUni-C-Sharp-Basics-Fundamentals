namespace _03.Equal_Sum_After_Extraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSumAfterExtraction
    {
        // You will be given two integer lists on the first two lines(space-separated). 
        // Remove the elements in the first list from the elements in the second list.
        // If an element from the first list occurs more than once in the second list, 
        // remove all occurrences.

        // After you remove the elements, check the sum of both lists. If the sum of both 
        // of them is equal, print “Yes. Sum: { sum}”. If not print the absolute difference 
        // between the two lists in the format “No.Diff: {sum}”.

        public static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            // Check each number in the first line.
            foreach (var number in firstLine)
            {
                // Check if any of the numbers from the first line is in the second line.
                if (secondLine.Contains(number))
                {
                    // Remove the numbers from the second line.
                    secondLine.Remove(number);
                }
            }

            // Sum the numbers from both lines.
            var firstLineSum = firstLine.Sum();
            var secondLineSum = secondLine.Sum();

            if (firstLineSum == secondLineSum)
            {
                Console.WriteLine("Yes. Sum: {0}", firstLineSum);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(firstLineSum - secondLineSum));
            }
        }
    }
}