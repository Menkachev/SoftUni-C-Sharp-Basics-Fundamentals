namespace _03.Text_Filter
{
    using System;

    public class TextFilter
    {
        //// Write a program that takes a text and a string of banned words. All words included 
        //// in the ban list should be replaced with asterisks "*", equal to the word's length. 
        //// The entries in the ban list will be separated by a comma and space ", ".

        //// The ban list should be entered on the first input line and the text on the second input line.

        public static void Main()
        {
            var banList = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var word in banList)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}