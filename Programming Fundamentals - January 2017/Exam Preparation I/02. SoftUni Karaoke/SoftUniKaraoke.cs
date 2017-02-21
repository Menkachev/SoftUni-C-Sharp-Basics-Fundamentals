namespace _02.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();

            var availableSongs = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            //// Count the participants names and their awards.
            var result = new Dictionary<string, List<string>>();

            var line = Console.ReadLine();

            while (line != "dawn")
            {
                var performance = line
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim())
                    .ToArray();

                var participant = performance[0];
                var song = performance[1];
                var award = performance[2];

                //// 1. If participant and the song are part from the input.
                if (participants.Contains(participant) && availableSongs.Contains(song))
                {
                    //// 2. If the dictionary doesn't contains key and value with that name...
                    if (!result.ContainsKey(participant))
                    {
                        //// 3. Put them in a new list in order to...
                        result[participant] = new List<string>();
                    }
                    //// 4. ...count the awards.
                    var awards = result[participant];

                    //// 5. ...and if "awards" doesn't have this award, add it.
                    if (!awards.Contains(award))
                    {
                        awards.Add(award);
                    }
                }

                line = Console.ReadLine();
            }

            if (result.Any())
            {
                //// Sort participants first by number of awards "OrderByDescending"
                //// and "ThenBy" name.
                foreach (var kvp in result
                    .OrderByDescending(p => p.Value.Count)
                    .ThenBy(p => p.Key))
                {
                    var participant = kvp.Key;
                    var awards = kvp.Value;

                    Console.WriteLine($"{participant}: {awards.Count} awards");

                    foreach (var award in awards.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}