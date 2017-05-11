namespace _08.Most_Frequent_Number
{
    using System;
    using System.Linq;
    public class MostFrequentNumber
    {
        // Write a program that finds the most frequent number in a given sequence of numbers.
        //  # Numbers will be in the range[0…65535].
        //  # In case of multiple numbers with the same maximal frequency, print the leftmost of them.

        public static void Main(string[] args)
        {
            // 80 / 100

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var counter = 1; // Will count how many times a number will repeat.
            var mostFrequently = 0; // Allways will keep the most frequently.
            var mostFrequentNum = 0; // The real number.

            for (int i = 0; i < input.Length; i++)
            {
                var currentNum = input[i];

                if (currentNum.Equals(input.Length))
                {
                    counter++;
                }
                else
                {
                    counter = 1; // Start count new sequence.
                }

                if (counter > mostFrequently)
                {
                    mostFrequently = counter; // If the current seq is > than the previous seq, it is the longest seq.
                    mostFrequentNum = currentNum; // Most frequent num is the current num - input[i].
                }
            }

            Console.WriteLine(mostFrequentNum);
        }
    }
}
