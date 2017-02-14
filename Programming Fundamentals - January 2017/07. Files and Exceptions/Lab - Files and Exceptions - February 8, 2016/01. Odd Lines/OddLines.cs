namespace _01.Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class OddLines
    {
        //// Write a program that reads a text file and writes its every odd line in another file. 
        //// Line numbers starts from 0. 

        public static void Main()
        {
            var file = "myfile.txt";

            var lines = File.ReadAllLines(file);

            var oddLines = new List<string>();

            //// Finds the odd lins and put them in the List.
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(lines[i]);
                }
            }

            //// Creates a new txt file with the odd lines in it.
            File.WriteAllLines("result.txt", oddLines);

            foreach (var line in oddLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}