namespace _02.Convert_from_base_N_to_base_10
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class ConvertFromBaseNtoBaseTen
    {
        //// Write a program that takes a base-N number and converts it to a base-10 number(0 to 1050), 
        //// where 2 <= N <= 10.
        //// The input consists of 1 line containing two numbers separated by a single space.
        //// The first number is the base N to which you have to convert.
        //// The second one is the base N number to be converted.

        //// Example: Input: 5 443 -> Output: 123

        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ').ToArray();

            var number = BigInteger.Parse(inputLine[1]);
            var numberBase = int.Parse(inputLine[0]);

            var result = ConvertedFromNbaseToBaseTen(numberBase, number);

            Console.WriteLine(result);
        }

        public static BigInteger ConvertedFromNbaseToBaseTen(int numberBase, BigInteger number)
        {
            var numAsString = number.ToString();

            var sum = new BigInteger(0);

            for (int i = 0; i < numAsString.Length; i++)
            {
                //// Start looping from the last index.
                var num = int.Parse(numAsString[numAsString.Length - 1 - i].ToString());

                var result = num * BigInteger.Pow(numberBase, i);

                sum = sum + result;
            }

            return sum;
        }
    }
}