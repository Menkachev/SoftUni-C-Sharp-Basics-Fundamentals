namespace _02.Dict_Ref_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var data = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var firstElement = tokens[0];
                var secondElement = tokens[1];

                var numbers = 0;
                if (int.TryParse(secondElement, out numbers))
                {
                    if (!data.ContainsKey(firstElement))
                    {
                        data[firstElement] = new List<int>();
                    }

                    for (int i = 1; i < tokens.Length; i++)
                    {
                        data[firstElement].Add(int.Parse(tokens[i]));
                    }
                }
                else
                {
                    var otherKey = tokens[1];

                    if (data.ContainsKey(otherKey))
                    {
                        data[firstElement] = new List<int>(data[otherKey]);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in data)
            {
                if (item.Value.Count > 0)
                {
                    var key = item.Key;
                    var value = item.Value;

                    Console.WriteLine($"{key} === {string.Join(", ", value)}");
                }
            }
        }
    }
}