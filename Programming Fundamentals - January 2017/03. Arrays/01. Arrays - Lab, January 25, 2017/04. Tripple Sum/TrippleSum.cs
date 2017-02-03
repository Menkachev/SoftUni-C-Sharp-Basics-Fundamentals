namespace _04.Tripple_Sum
{
    using System;
    using System.Linq;

    public class TrippleSum
    {
        //// Write a program to read an array of integers and find all triples 
        //// of elements a, b and c, such that a + b == c (where a stays left from b). 
        //// Print “No” if no such triples exist.

        //// Example: 

        //// Input: 1 1 1 1 -> Output: No;  

        //// Input: 4 2 8 6 -> Output: 4 + 2 == 6 
        ////                           2 + 6 == 8

        public static void Main()
        {
            var stringNumbers = Console.ReadLine().Split();
            var intNumbers = new int[stringNumbers.Length];

            for (int i = 0; i < intNumbers.Length; i++)
            {
                intNumbers[i] = int.Parse(stringNumbers[i]);
            }

            var foundIt = false;

            for (int first = 0; first < intNumbers.Length; first++)
            {
                var firstNum = intNumbers[first];

                for (int second = first + 1; second < intNumbers.Length; second++)
                {
                    var seconNum = intNumbers[second];
                    var sum = firstNum + seconNum;

                    if (intNumbers.Contains(sum))
                    {
                        Console.WriteLine($"{firstNum} + {seconNum} == {sum}");
                        foundIt = true;
                    }
                }
            }

            if (!foundIt)
            {
                Console.WriteLine("No");
            }
        }
    }
}