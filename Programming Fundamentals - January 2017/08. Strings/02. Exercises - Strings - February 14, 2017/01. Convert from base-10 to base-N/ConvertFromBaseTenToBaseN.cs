namespace _01.Convert_from_base_10_to_base_N
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class ConvertFromBaseTenToBaseN
    {
        public static int ConvertedFromBase { get; private set; }

        //// Write a program that takes a base-10 number(0 to 1050) and converts it to a base-N number, 
        //// where 2 <= N <= 10.
        //// The input consists of 1 line containing two numbers separated by a single space. 
        //// The first number is the base "N" to which you have to convert. The second one is 
        //// the base 10 number to be converted.

        //// Example: Input: 7 10 -> Output: 13

        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ').ToArray();

            var baseNum = int.Parse(inputLine[0]);
            var number = BigInteger.Parse(inputLine[1]);

            var result = ConvertedFromBaseToBaseN(baseNum, number);

            Console.WriteLine(result);
        }

        private static object ConvertedFromBaseToBaseN(int baseNum, BigInteger number)
        {
            var result = string.Empty;

            while (number > 0)
            {
                var converted = number % baseNum;

                result = converted + result;
                number /= baseNum;
            }

            return result;
        }
    }
}