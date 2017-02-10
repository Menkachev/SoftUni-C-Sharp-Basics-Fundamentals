namespace _02.Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RandomizeWords
    {
        //// You are given a list of words in one line. 
        //// Randomize their order and print each word at a separate line.

        public static void Main()
        {
            var words = Console.ReadLine().Split(' ');

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWords = words[i];
                var randomIndex = random.Next(0, words.Length);

                var tempWord = words[randomIndex];

                words[i] = tempWord;
                words[randomIndex] = currentWords;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}