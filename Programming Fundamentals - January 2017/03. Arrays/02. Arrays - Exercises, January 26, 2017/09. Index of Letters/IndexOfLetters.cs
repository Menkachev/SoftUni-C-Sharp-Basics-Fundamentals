namespace _09.Index_of_Letters
{
    using System;
    public class IndexOfLetters
    {
        // Write a program that creates an array containing all letters from the alphabet(a-z). 
        // Read a lowercase word from the console and print the index of each of its letters in the letters array.
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            foreach (var ch in input)
            {
                Console.WriteLine($"{ch} -> {ch - 'a'}");
            }
        }
    }
}
