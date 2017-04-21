namespace _03.English_Name_of_Last_Digit
{
    using System;

    public class EnglishNameOfLastDigit
    {
        // Write a method that returns the English name of the last digit of a given number.
        // Write a program that reads an integer and prints the returned value from this method.

        // Example: Input: 1024 -> Output: four

        public static void Main()
        {
            var num = long.Parse(Console.ReadLine());

            ConvertDigitInWord(num);
        }

        public static void ConvertDigitInWord(long num)
        {
            var lastNum = Math.Abs(num % 10);

            switch (lastNum)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;

                default:
                    break;
            }
        }
    }
}