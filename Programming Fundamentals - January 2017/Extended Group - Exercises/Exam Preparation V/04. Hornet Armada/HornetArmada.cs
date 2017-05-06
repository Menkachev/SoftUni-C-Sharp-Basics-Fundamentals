namespace Exercise_4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class HornetArmada
    {
        public class SoldierInfo
        {
            public int LastActivity { get; set; }

            public string LegionName { get; set; }

            public string Type { get; set; }

            public long Count { get; set; }

            public int Order { get; set; }
        }
        public static void Main(string[] args)
        {
            var soldiers = new List<SoldierInfo>();

            var activities = new Dictionary<string, int>();
            var orders = new Dictionary<string, int>();

            var n = int.Parse(Console.ReadLine());

            var order = 0;

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = int.Parse(inputLine[0]);
                var legionName = inputLine[1];

                if (!activities.ContainsKey(legionName) || activities[legionName] < lastActivity)
                {
                    activities[legionName] = lastActivity;
                }

                order++;

                if (!orders.ContainsKey(legionName) || orders[legionName] > order)
                {
                    orders[legionName] = order;
                }

                soldiers.Add(new SoldierInfo
                {
                    LastActivity = activities[legionName],
                    LegionName = legionName,
                    Type = inputLine[2],
                    Count = long.Parse(inputLine[3]),
                    Order = order
                });
            }

            foreach (var soldierInfo in soldiers)
            {
                soldierInfo.LastActivity = activities[soldierInfo.LegionName];
                soldierInfo.Order = orders[soldierInfo.LegionName];
            }

            var command = Console.ReadLine(); // Read the new command.

            if (command.Contains("\\"))
            {
                var commandParts = command.Split('\\'); // Split the command...

                var activity = int.Parse(commandParts[0]);
                var soldierType = commandParts[1];

                var result = soldiers // Linq
                    .Where(s => s.Type == soldierType && s.LastActivity < activity)
                    .GroupBy(s => s.LegionName) // Legions.
                    .Select(gr => new
                    {
                        LegionName = gr.Key, // Legion name.
                        Count = gr.Sum(s => s.Count), // Count of soldiers type in the legion.
                        Order = gr.Min(s => s.Order)
                    })
                    .OrderByDescending(s => s.Count) // Descending order by soldier count.
                    .ThenBy(s => s.Order)
                    .ToList();

                foreach (var info in result)
                {
                    Console.WriteLine($"{info.LegionName} -> {info.Count}");
                }
            }
            else
            {
                var soldierType = command;

                var result = soldiers
                    .Where(s => s.Type == soldierType)
                    .GroupBy(s => s.LegionName)
                    .Select(gr => new
                    {
                        LegionName = gr.Key,
                        LastActivity = gr.Max(s => s.LastActivity),
                        Order = gr.Min(s => s.Order)
                    })
                    .OrderByDescending(s => s.LastActivity)
                    .ThenBy(s => s.Order)
                    .ToList();

                foreach (var info in result)
                {
                    Console.WriteLine($"{info.LastActivity} : {info.LegionName}");
                }
            }
        }
    }
}
