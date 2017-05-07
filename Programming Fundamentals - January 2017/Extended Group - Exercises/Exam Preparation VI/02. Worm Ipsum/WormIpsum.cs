namespace Problem_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class WormIpsum
    {
        public static void Main(string[] args)
        {
            var sentenceReg = new Regex(@"^[A-Z][^\.]*\.$");

            var inputLine = Console.ReadLine();

            while (inputLine != "Worm Ipsum")
            {
                var sentenceMatch = sentenceReg.Match(inputLine);
                if (sentenceMatch.Success)
                {
                    string[] inputParams = inputLine
                        .Split(new[] { ". " }, StringSplitOptions.RemoveEmptyEntries);

                    string[] sentence = inputParams[0]
                        .Split(" .".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < sentence.Length; i++)
                    {
                        char[] characters = sentence[i].ToCharArray();

                        Dictionary<char, int> counts = new Dictionary<char, int>();

                        foreach (var character in characters)
                        {
                            if (!counts.ContainsKey(character))
                                counts[character] = 0;

                            counts[character]++; // Count number of repeads.
                        }

                        IOrderedEnumerable<KeyValuePair<char, int>> orderedCounts = counts.OrderByDescending(x => x.Value); // Sort repeated characters.
                        char element = orderedCounts.First().Key;
                        int count = orderedCounts.First().Value;

                        if (count > 1)
                        {
                            if (sentence[i].Contains(","))
                                sentence[i] = new string(element, sentence[i].Length - 1) + ",";
                            else
                                sentence[i] = new string(element, sentence[i].Length);
                        }
                    }

                    Console.WriteLine(string.Join(" ", sentence) + ".");
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
