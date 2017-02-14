namespace _01.Reverse_String
{
    using System;

    public class ReverseString
    {
        //// Write a program that reads a string from the console, reverses it 
        //// and prints the result back at the console.

        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            Array.Reverse(input);

            Console.WriteLine(input);
        }
    }
}