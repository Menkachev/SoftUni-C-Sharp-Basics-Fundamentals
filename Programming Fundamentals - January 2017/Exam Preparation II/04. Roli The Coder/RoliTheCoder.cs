namespace _04.Roli_The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class RoliTheCoder
    {
        public static void Main(string[] args)
        {
            List<Event> events = new List<Event>();

            string request = Console.ReadLine();

            while (request != "Time for Code")
            {
                List<string> requestEll = request.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string id = requestEll[0];
                string name = requestEll[1];
                List<string> currentParticipants = requestEll.Skip(2).ToList();

                if (!name.StartsWith("#") || (events.Any(e => e.ID == id && e.Name != name.TrimStart('#'))))
                {
                    request = Console.ReadLine();
                    continue;
                }

                if (events.Any(x => x.ID == id))
                {
                    int index = events.FindIndex(x => x.ID == id);
                    for (int i = 0; i < currentParticipants.Count; i++)
                    {
                        events[index].Participants.Add(currentParticipants[i]);
                    }
                }
                else
                {
                    events.Add(new Event()
                    {
                        ID = id,
                        Name = name.TrimStart('#'),
                        Participants = new SortedSet<string>(currentParticipants)

                    });
                }

                request = Console.ReadLine();
            }

            foreach (var item in events.OrderByDescending(x => x.Participants.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Participants.Count}");
                foreach (var participant in item.Participants.OrderBy(x => x))
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }
    }
}
