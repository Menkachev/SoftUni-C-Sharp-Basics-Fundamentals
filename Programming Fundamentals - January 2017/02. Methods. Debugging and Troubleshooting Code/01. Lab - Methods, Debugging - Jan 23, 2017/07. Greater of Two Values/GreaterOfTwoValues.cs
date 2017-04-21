namespace _07.Greater_of_Two_Values
{
    using System;
    public class GreaterOfTwoValues
    {
        // You are given two values of the same type as input.
        // The values can be of type int, char of string. 
        // Create a method GetMax() that returns the greater of the two values.

        // Examples: Input: int, 2, 16 -> Output: 16     Input: char, a, z -> Output: z

        // Get max integer.
        public static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        // Get max char.
        public static char GetMax(char firstChar, char secondChar)
        {
            char greaterChar = firstChar;

            if (secondChar > firstChar)
            {
                greaterChar = secondChar;
            }

            return greaterChar;
        }

        // Get max string.
        public static string GetMax(string firstString, string secondString)
        {
            string greaterString = string.Empty;

            if (firstString.CompareTo(secondString) >= 0)
            {
                greaterString = firstString;
            }
            else
            {
                greaterString = secondString;
            }

            return greaterString;
        }

        // Print the result.
        public static void Main()
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int maxNumber = GetMax(firstNumber, secondNumber);

                Console.WriteLine(maxNumber);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char maxChar = GetMax(firstChar, secondChar);

                Console.WriteLine(maxChar);
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string maxString = GetMax(firstString, secondString);

                Console.WriteLine(maxString);
            }
        }
    }
}