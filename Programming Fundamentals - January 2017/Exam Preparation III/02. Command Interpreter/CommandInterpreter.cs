namespace _02.Command_Interpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var commandParams = inputLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = commandParams[0];

                switch (command)
                {
                    case "reverse":
                        var reverseStart = int.Parse(commandParams[2]);
                        var reverseCount = int.Parse(commandParams[4]);

                        if (IsValid(array, reverseStart, reverseCount))
                        {
                            ////Reverse(array, reversedStart, reversedCount);
                            array.Reverse(reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "sort":
                        var sortStart = int.Parse(commandParams[2]);
                        var sortCount = int.Parse(commandParams[4]);

                        if (IsValid(array, sortStart, sortCount))
                        {
                            array.Sort(sortStart, sortCount, StringComparer.InvariantCulture);
                            ////Sort(array, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollLeft":
                        var rollLeftCount = int.Parse(commandParams[1]);

                        if (rollLeftCount >= 0)
                        {
                            RollLeft(array, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollRight":
                        var rollRightCount = int.Parse(commandParams[1]);

                        if (rollRightCount >= 0)
                        {
                            RollRight(array, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private static void RollRight(List<string> array, int rollRightCount)
        {
            rollRightCount = rollRightCount % array.Count;

            for (int i = 0; i < rollRightCount; i++)
            {
                var lastElem = array[array.Count - 1];
                array.RemoveAt(array.Count - 1);
                array.Insert(0, lastElem);
            }
        }

        private static void RollLeft(List<string> array, int rollLeftCount)
        {
            rollLeftCount = rollLeftCount % array.Count;

            for (int i = 0; i < rollLeftCount; i++)
            {
                var firstElem = array[0];

                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Count - 1] = firstElem;
            }
        }

        ////private static void Sort(List<string> array, int sortStart, int sortCount)
        ////{
        ////    var resultArray = array.Skip(sortStart).Take(sortCount).OrderBy(x => x).ToList();

        ////    array.RemoveRange(sortStart, sortCount);
        ////    array.InsertRange(sortStart, resultArray);
        ////}

        ////private static void Reverse(List<string> array, int start, int count)
        ////{
        ////    var resultArray = array.Skip(start).Take(count).Reverse().ToList();

        ////    array.RemoveRange(start, count);
        ////    array.InsertRange(start, resultArray);
        ////}

        private static bool IsValid(List<string> array, int start, int count)
        {
            if (start >= 0 && start < array.Count && count >= 0 && (start + count) <= array.Count)
            {
                return true;
            }

            return false;
        }
    }
}