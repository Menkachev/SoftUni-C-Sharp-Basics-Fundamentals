namespace _08.Multiply_Evens_by_Odds
{
    using System;
    public class MultipleEvensByOdds
    {
        // Create a program that reads an integer number and multiplies the sum of all 
        // its even digits by the sum of all its odd digits.

        // Example: Input: 12345 -> Output: 54

        // Comments: 12345 has 2 even digits - 2 and 4. Even digits has sum of 6.
        //           Also it has 3 odd digits - 1, 3 and 5. Odd digits has sum of 9.
        //           Multiply 6 by 9 and you get 54.

        // Sum of odds.
        private static int GetSumOfOdds(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                num /= 10;
            }

            return sum;
        }

        // Sum of evens.
        private static int GetSumOfEvens(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                num /= 10;
            }

            return sum;
        }

        // Multyple odds and evens.
        private static int GetMultypleOfEvensAndOdds(int num)
        {
            int oddSum = GetSumOfOdds(num);
            int evenSum = GetSumOfEvens(num);

            return oddSum * evenSum;
        }

        // Print the result on the console.
        private static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultypleOfEvensAndOdds(Math.Abs(num)));
        }
    }
}