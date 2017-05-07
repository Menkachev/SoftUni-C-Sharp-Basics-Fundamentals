namespace Problem_4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class WormsWorldParty
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> teams = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "quit")
            {
                var tokents = inputLine
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string wormName = tokents[0];
                string wormTeam = tokents[1];
                var wormScore = int.Parse(tokents[2]);

                bool wormExist = false;
                foreach (var kvp in teams)
                {
                    if (kvp.Value.ContainsKey(wormName))
                    {
                        wormExist = true;
                    }
                }

                if (!wormExist) // If wormName does not exist...
                {
                    if (!teams.ContainsKey(wormTeam))
                    {
                        teams[wormTeam] = new Dictionary<string, int>();
                    }

                    if (!teams[wormTeam].ContainsKey(wormName))
                    {
                        teams[wormTeam][wormName] = 0;
                    }

                    teams[wormTeam][wormName] += wormScore;
                }

                inputLine = Console.ReadLine();
            }

            teams = teams
                .OrderByDescending(x => x.Value.Sum(y => y.Value)) // Ordered by total score of their worms, in descending order 
                .ThenByDescending(x => x.Value.Sum(y => y.Value) / x.Value.Count) // If 2 teams have the same total score (totalScore / wormCount) indescending order. 
                .ToDictionary(x => x.Key, x => x.Value);

            var count = 1;

            foreach (var team in teams)
            {
                Console.WriteLine($"{count}. Team:{team.Key} - {team.Value.Sum(x => x.Value)}");

                foreach (var worm in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }

                count++;
            }
        }
    }
}
