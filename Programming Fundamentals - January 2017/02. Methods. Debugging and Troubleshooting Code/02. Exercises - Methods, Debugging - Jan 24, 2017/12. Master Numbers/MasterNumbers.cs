namespace _12.Master_Number
{
    using System;

    public class MasterNumbers
    {
        // A master number is an integer that holds the following properties:
        //    # Is symmetric(palindrome), e.g. 5, 77, 282, 14341, 9553559.
        //    # Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
        //    # Holds at least one even digit, e.g. 232, 707, 6886, 87578.

        // Write a program to print all master numbers in the range[1…n].

        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (
                    IsPalindrome(i) == true
                    && SumOfDigit(i) == true
                    && ContainsEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Is symmetric(palindrome).
        private static bool IsPalindrome(int num)
        {
            string stringNum = num.ToString();

            if (stringNum.Length < 4 && (stringNum[0] == stringNum[stringNum.Length - 1]))
            {
                return true;
            }
            else if (
                stringNum.Length < 6
                && (stringNum[0] == stringNum[stringNum.Length - 1]
                && stringNum[1] == stringNum[stringNum.Length - 2]))
            {
                return true;
            }
            else if (
                stringNum.Length < 8
                && (stringNum[0] == stringNum[stringNum.Length - 1]
                && stringNum[1] == stringNum[stringNum.Length - 2]
                && stringNum[2] == stringNum[stringNum.Length - 3]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Holds even digit.
        private static bool ContainsEvenDigit(int num)
        {
            var stringNum = num.ToString();
            var evenCounter = 0;

            for (int i = 0; i < stringNum.Length; i++)
            {
                var currentDigit = int.Parse(stringNum[i].ToString());

                if (currentDigit % 2 == 0)
                {
                    evenCounter++;
                }
            }

            if (evenCounter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // It's sum of digits is divisible by 7.
        private static bool SumOfDigit(int num)
        {
            var stringNum = num.ToString();
            var sumOfDigits = 0;

            for (int i = 0; i < stringNum.Length; i++)
            {
                sumOfDigits += int.Parse(stringNum[i].ToString());
            }

            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}