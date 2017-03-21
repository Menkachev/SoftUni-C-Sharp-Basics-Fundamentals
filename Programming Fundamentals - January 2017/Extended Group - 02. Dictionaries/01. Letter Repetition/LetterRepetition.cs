namespace _01.Letter_Repetition
{
    using System;
    using System.Collections.Generic;

    public class LetterRepetition
    {
        // You will be given a single string, containing random ASCII character. 
        // Your task is to print every character, and how many times it has been 
        // used in the string.

        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!result.ContainsKey(letter))
                {
                    result[letter] = 0;
                }

                result[letter]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}