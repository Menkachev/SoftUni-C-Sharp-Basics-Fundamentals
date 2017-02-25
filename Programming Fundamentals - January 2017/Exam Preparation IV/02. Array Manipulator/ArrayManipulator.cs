namespace _02.Array_Manipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                var commandParts = line
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandParts[0])
                {
                    case "exchange":
                        array = Exchange(array, int.Parse(commandParts[1]));
                        break;
                    case "max":
                    case "min":
                        MaxAndMin(array, commandParts[0], commandParts[1]);
                        break;
                    case "first":
                    case "last":
                        FirstAndLast(array, commandParts[0], int.Parse(commandParts[1]), commandParts[2]);
                        break;
                }
            }

            PrintArray(array);
        }

        private static void FirstAndLast(int[] array, string command, int count, string evenOrOdd)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var filter = FilterEvenOrOdd(array, evenOrOdd);

            int[] result;

            if (command == "first")
            {
                result = filter.Take(count).ToArray();
            }
            else
            {
                result = filter.Reverse().Take(count).Reverse().ToArray();
            }

            PrintArray(result);
        }

        private static void MaxAndMin(int[] array, string command, string evenOrOdd)
        {
            var filter = FilterEvenOrOdd(array, evenOrOdd);

            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var result = command == "Max"
                ? filter.Max()
                : filter.Min();

            Console.WriteLine(Array.LastIndexOf(array, result));
        }

        private static int[] Exchange(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            var left = array.Take(index + 1);
            var right = array.Skip(index + 1);

            return right.Concat(left).ToArray();
        }

        private static int[] FilterEvenOrOdd(int[] array, string evenOrOdd)
        {
            return array
                .Where(n => evenOrOdd == "even"
                 ? n % 2 == 0
                 : n % 2 == 1)
                 .ToArray();
        }

        private static void PrintArray(int[] array)
        {
            var arrayAsString = string.Join(", ", array);
            Console.WriteLine($"[{arrayAsString}]");
        }
    }
}