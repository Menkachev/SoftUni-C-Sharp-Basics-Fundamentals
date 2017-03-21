namespace _02.Dict_Ref
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dict_Ref
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, int>();

            while (input != "end")
            {
                var line = input
                    .Split()
                    .ToList();

                var name = line[0];
                var lastElement = line[line.Count - 1];

                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    result[name] = number;
                }
                else
                {
                    if (result.ContainsKey(lastElement))
                    {
                        var referenceValue = result[lastElement];
                        result[name] = referenceValue;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var itemPrice in result)
            {
                var name = itemPrice.Key;
                var price = itemPrice.Value;

                Console.WriteLine($"{name} === {price}");
            }
        }
    }
}