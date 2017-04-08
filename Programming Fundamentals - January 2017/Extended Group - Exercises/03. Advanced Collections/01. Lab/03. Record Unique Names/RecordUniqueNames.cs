namespace _03.Record_Unique_Names
{
    using System;
    using System.Collections.Generic;

    public class RecordUniqueNames
    {
        // Write a program, which will take a list of names and print only the unique names 
        // in the list.

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                set.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, set));
        }
    }
}