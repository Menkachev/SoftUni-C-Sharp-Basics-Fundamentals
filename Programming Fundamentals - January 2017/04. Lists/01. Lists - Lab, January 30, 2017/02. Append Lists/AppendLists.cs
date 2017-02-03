namespace _02.Append_Lists
{
    using System;
    using System.Linq;

    public class AppendLists
    {
        //// Write a program to append several lists of numbers.
        ////    Lists are separated by ‘|’.
        ////    Values are separated by spaces(‘ ’, one or several)
        ////    Order the lists from the last to the first, and their values from left to right.

        public static void Main()
        {
            var lists = Console.ReadLine().Split('|').ToList();

            lists.Reverse();

            Console.WriteLine(string.Join(" ", lists));
        }
    }
}
