namespace _09.Reversed_chars
{
    using System;

    public class ReversedChars
    {
        //// Write a program to ask the user for 3 letters and print them in reversed order.

        public static void Main()
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var thirdLatter = char.Parse(Console.ReadLine());

            Console.Write(thirdLatter);
            Console.Write(secondLetter);
            Console.WriteLine(firstLetter);
        }
    }
}