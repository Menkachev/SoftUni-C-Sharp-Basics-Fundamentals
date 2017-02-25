namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());

            var ladybugsIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(a => a >= 0 && a <= fieldSize)
                .ToArray();

            var ladybugs = new int[fieldSize];

            for (int i = 0; i < ladybugsIndexes.Length; i++) //// Put the ladybugs in the field.
            {
                var currentLadyBugIndex = ladybugsIndexes[i];
                ladybugs[currentLadyBugIndex] = 1;
            }

            var line = Console.ReadLine();

            while (line != "end")
            {
                var commands = line.Split();

                var index = int.Parse(commands[0]);
                var direction = commands[1];
                var flyLength = int.Parse(commands[2]);

                if (index < 0 || index >= ladybugs.Length) //// If the index is not valid.
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (ladybugs[index] == 0) //// If the index is valid, but empty.
                {
                    line = Console.ReadLine();
                    continue;
                }

                MoveLadyBug(ladybugs, index, flyLength, direction);

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }

        public static void MoveLadyBug(int[] ladybugs, int index, int flyLength, string direction)
        {
            ladybugs[index] = 0;

            var leftArrayOrFoundPlace = false;

            while (!leftArrayOrFoundPlace)
            {
                switch (direction) //// Move the flybug left or right.
                {
                    case "left":
                        index = index - flyLength;
                        break;

                    case "right":
                        index = index + flyLength;
                        break;
                }

                if (index < 0 || index >= ladybugs.Length)
                {
                    leftArrayOrFoundPlace = true; //// Left array.
                    continue;
                }

                if (ladybugs[index] == 1)
                {
                    continue; //// Stepped over another ladybug, keep flying.
                }

                if (ladybugs[index] == 0)
                {
                    ladybugs[index] = 1;
                    leftArrayOrFoundPlace = true; //// Found its place in the array.
                    continue;
                }
            }
        }
    }
}