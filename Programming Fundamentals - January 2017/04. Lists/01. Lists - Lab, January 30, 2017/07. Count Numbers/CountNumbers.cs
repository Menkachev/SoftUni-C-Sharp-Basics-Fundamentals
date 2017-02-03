namespace _07.Count_Numbers
{
    using System;
    using System.Linq;

    public class CountNumbers
    {
        //// Read a list of integers in range[0…1000] and print them in ascending order 
        //// along with their number of occurrences.

        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            if (numbers.Count > 0)
            {
                numbers.Sort();

                var previous = numbers[0];
                var count = 1;

                for (int i = 1; i < numbers.Count; i++)
                {
                    var currentNum = numbers[i];

                    if (currentNum == previous)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{previous} - {count}");
                        count = 1;
                    }

                    previous = currentNum;
                }

                Console.WriteLine($"{previous} - {count}");
            }
        }
    }
}