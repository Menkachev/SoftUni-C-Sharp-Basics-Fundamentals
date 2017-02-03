namespace _13.Vowel_or_Digit
{
    using System;

    public class VowelOrDigit
    {
        //// Create a program to check if given symbol is digit, vowel or any other symbol.

        //// Example: Input: a -> Output: vowel,  Input: 9 -> Output: digit

        public static void Main()
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' || input == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (input == '1' || input == '2' || input == '3' || input == '4' || input == '5' || input == '6' || input == '7' || input == '8' || input == '9' || input == '0')
            {
                Console.WriteLine("digit");
            }
            else 
            {
                Console.WriteLine("other");
            }
        }
    }
}