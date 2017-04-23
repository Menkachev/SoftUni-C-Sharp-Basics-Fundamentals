namespace _02.Extract_sentences_by_keyword
{
    using System;
    using System.Text.RegularExpressions;
    public class ExtractSentencesByKeyword
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string[] sentences = Console.ReadLine()
                .Split(new[] { ".", "?", "!" }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = "\\b" + word + "\\b";

            Regex regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
