namespace _06.Reverse_Array_of_Strings
{
    using System;
    using System.Linq;

    public class ReverseArrayOfString
    {
        //// Write a program to read an array of strings, reverse it and print its elements.
        //// The input consists of a sequence of space separated strings.
        //// Print the output on a single line (space separated).

        //// Example: Input: a b c d e -> Output: e d c b a

        public static void Main()
        {
            var elements = Console.ReadLine().Split();

            for (int i = 0; i < elements.Length / 2; i++)
            {
                var temp = elements[i];
                var reversed = elements.Length - i - 1;
                elements[i] = elements[reversed];
                elements[reversed] = temp;
            }

            Console.WriteLine(string.Join(" ", elements));

            //// Solution in one sentance with "Reverse()" and "Join"

            // var reversed = elements.Reverse();

            // Console.WriteLine(string.Join(" ", reversed));
        }
    }
}