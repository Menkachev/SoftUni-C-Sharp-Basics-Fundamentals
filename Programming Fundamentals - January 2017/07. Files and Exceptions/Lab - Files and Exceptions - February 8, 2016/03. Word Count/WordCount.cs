namespace _03.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    
    public class WordCount
    {
        //// Write a program that reads a list of words from the file words.txt and finds how many times 
        //// each of the words is contained in another file text.txt. Matching should be case-insensitive.

        //// The result should be written to another text file. Sort the words by frequency in descending order.

        public static void Main()
        {
            var words = File.ReadAllText("words.txt")
                .Split(new[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .Distinct()
                .ToList();

            var text = File.ReadAllText("text.txt")
                .Split(new[] { ' ', ',', '.', '-', '!', '?', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .ToList();

            var result = new Dictionary<string, int>();

            //// Nested loop in order to: first read all words from the console;
            //// second is to check how many times the current word repeat in the text.
            for (int i = 0; i < words.Count; i++)
            {
                var currentWord = words[i];
                var currentWordCount = 0;

                for (int j = 0; j < text.Count; j++)
                {
                    if (currentWord == text[j])
                    {
                        currentWordCount++;
                    }
                }

                result[currentWord] = currentWordCount;
            }

            var sortedResult = result
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToList();

            File.WriteAllLines("result.txt", sortedResult);
        }
    }
}