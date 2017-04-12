namespace _03.Unicode_Characters
{
    using System;

    public class UnicodeCharacters
    {
        // Write a program that converts a string to a sequence of Unicode character literals.

        // Example: Input: Hi! -> Output: \u0048\u0069\u0021

        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            foreach (var simbol in input)
            {
                Console.Write($"\\u{(int)simbol:x4}");
            }

            Console.WriteLine();
        }
    }
}