namespace _05.Tear_List_in_Half
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TearListInHalf
    {
        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> leftPart = new List<int>();
            List<int> rightPart = new List<int>();
            List<int> output = new List<int>();

            // Left part
            for (int i = 0; i < input.Count / 2; i++)
            {
                leftPart.Add(input[i]);
            }

            // Right part
            input.Reverse();

            for (int i = 0; i < input.Count / 2; i++)
            {
                rightPart.Add(input[i]);
            }

            rightPart.Reverse();

            // Zip them in the right order.
            for (int i = 0; i < leftPart.Count; i++)
            {
                // Divided by 10 remove last digit.
                output.Add(rightPart[i] / 10);
                output.Add(leftPart[i]);
                // % by 10 print the last digit.
                output.Add(rightPart[i] % 10);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}