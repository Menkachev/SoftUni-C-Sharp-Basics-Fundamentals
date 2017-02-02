namespace _09.Extract_Middle_Elements
{
    using System;
    using System.Linq;

    public class ExtractMiddleElements
    {
        //// Write a method to extract the middle 1, 2 or 3 elements from array of "n" integers and print them.

        public static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (n.Length == 1)
            {
                Console.WriteLine(n[0]);
            }
            else if (n.Length % 2 == 0)
            {
                Console.WriteLine(n[(n.Length / 2) - 1] + ", " + n[n.Length / 2]);
            }
            else if (n.Length % 2 != 0)
            {
                Console.WriteLine(n[(n.Length / 2) - 1] + ", " + n[n.Length / 2] + ", " + n[(n.Length / 2) + 1]);
            }
        }
    }
}
