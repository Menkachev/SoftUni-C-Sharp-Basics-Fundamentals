namespace _04.Flip_List_Sides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlipListSides
    {
        // You will receive an integer list on the first line of the input(space-separated). 
        // Leave the first, middle and last elements as they are. For every other element, 
        // exchange it with its opposite indexed element (list[1] => list[length - 2] and so on…).
        // After that, print the list on the console(space-separated).

        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> middleDigits = new List<int>();
            List<int> firstDigit = new List<int>();
            List<int> lastDigit = new List<int>();

            // Keep the first digit from the input.
            firstDigit.Add(input[0]);
            // Keep the last digit from the input.
            lastDigit.Add(input[input.Count - 1]);

            // Loop from the second digit to the digit before the last digit.
            for (int i = 1; i <= input.Count - 2; i++)
            {
                // Keep the middle digits in a list.
                middleDigits.Add(input[i]);
            }
            
            // Reverse middle digits.
            middleDigits.Reverse();
            // Concat first digit with middle digits and now you have the first part.
            var firstPart = firstDigit.Concat(middleDigits);
            // At the end concat first part with the last digit.
            var result = firstPart.Concat(lastDigit);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}