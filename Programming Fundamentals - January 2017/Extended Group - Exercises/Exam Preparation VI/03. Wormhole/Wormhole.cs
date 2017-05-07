namespace Problem_3
{
    using System;
    using System.Linq;
    public class Wormhole
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var steps = 0;

            for (int i = 0; i < n.Count; i++)
            {
                if (n[i] == 0)
                {
                    steps++;
                }
                else
                {
                    var current = n[i];
                    n[i] = 0;
                    i = current - 1; // One step back!
                }
            }

            Console.WriteLine(steps);
        }
    }
}
