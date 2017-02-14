namespace _02.Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class LineNumbers
    {
        //// Write a program that reads a text file and inserts line numbers in front of each of its lines.
        //// The result should be written to another text file. 

        public static void Main()
        {
            var file = "myfile.txt";

            var lines = File.ReadAllLines(file);

            var linesWithNumbers = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                linesWithNumbers.Add($"{i + 1}. {lines[i]}");
            }

            File.WriteAllLines("result.txt", linesWithNumbers);

            foreach (var line in linesWithNumbers)
            {
                Console.WriteLine(line);
            }
        }
    }
}