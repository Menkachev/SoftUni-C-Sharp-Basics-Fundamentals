namespace _04.Character_Multiplier
{
    using System;

    public class CharacterMultiplier
    {
        // Create a method that takes two strings as arguments and returns the sum of their character 
        // codes multiplied(multiply str1.charAt (0) with str2.charAt(0) and add to the total sum). 
        // Then continue with the next two characters. If one of the strings is longer than the 
        // other, add the remaining character codes to the total sum without multiplication.

        // Example: Input: Gosho Pesho -> Output: 53253

        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var first = input[0];
            var second = input[1];

            var sum = GetSum(first, second);

            Console.WriteLine(sum);
        }

        public static int GetSum(string first, string second)
        {
            // Different arrays for each word.
            var firstArr = first.ToString().ToCharArray();
            var secondArr = second.ToString().ToCharArray();

            // The sum between.
            var sum = 0;

            // Find min and max length between.
            var minLength = Math.Min(firstArr.Length, secondArr.Length);
            var maxLength = Math.Max(firstArr.Length, secondArr.Length);

            // Multiply the relevant indexes and sum it.
            for (int i = 0; i < minLength; i++)
            {
                sum += firstArr[i] * secondArr[i];
            }

            // Sum the rest of the characters from the longer word with the current sum.
            if (maxLength == firstArr.Length)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    sum = sum + firstArr[i];
                }
            }
            else
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    sum = sum + secondArr[i];
                }
            }

            return sum;
        }
    }
}