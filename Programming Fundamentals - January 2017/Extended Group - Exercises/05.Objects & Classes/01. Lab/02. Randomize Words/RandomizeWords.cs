namespace _02.Randomize_Words
{
    using System;
    using System.Linq;

    public class RandomizeWords
    {
        // You are given a list of words in one line. 
        // Randomize their order and print each word at a separate line.

        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomPosition = random.Next(0, words.Length);

                var temporaryWord = words[randomPosition];
                words[randomPosition] = currentWord;
                words[i] = temporaryWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}