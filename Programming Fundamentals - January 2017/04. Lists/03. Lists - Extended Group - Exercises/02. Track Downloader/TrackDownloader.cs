namespace _02.Track_Downloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrackDownloader
    {
        //// You will receive a list of blacklisted words(on the same line, separated by one space). 
        //// On the next lines, you will start receiving a list of filenames(as strings) until you 
        ////receive the string “end”. Your task is to add the filenames to a list and sort them.
        //// Ignore the tracks which contain the text in the blacklist.

        public static void Main(string[] args)
        {
            var blacklist = Console.ReadLine()
                .Split(' ')
                .ToList();
            // This list will keep the permited songs.
            var result = new List<string>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                // Boolean to track blacklisted words.
                var isWordInTheInput = false;

                // Check each word in the blacklist.
                foreach (var word in blacklist)
                { 
                    // Check if inplutLine contains some of the words in the blacklist.
                    if (inputLine.Contains(word))
                    {
                        isWordInTheInput = true;
                        break;
                    }
                }

                // Add all permited songs in the list.
                if (!isWordInTheInput)
                {
                    result.Add(inputLine);
                }

                inputLine = Console.ReadLine();
            }

            // Sort the listed songs.
            result.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, result));   
        }
    }
}