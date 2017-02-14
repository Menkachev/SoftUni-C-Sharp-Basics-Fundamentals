namespace _04.Merge_Files
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        //// Write a program that reads the contents of two text files 
        //// and merges them together into a third one.

        //// Example: Input: 1 3 5, 2 4 6 -> Output: 1 2 3 4 5 6

        public static void Main()
        {
            var firstInput = File.ReadAllLines("firstinput.txt");
            var secondInput = File.ReadAllLines("secondinput.txt");

            var result = new List<string>();

            result.AddRange(firstInput);
            result.AddRange(secondInput);

            result = result.OrderBy(n => n).ToList();

            File.WriteAllLines("result.txt", result);
        }
    }
}