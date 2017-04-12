namespace _07.Multiply_big_number
{
    using System;
    using System.Numerics;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var firstNum = BigInteger.Parse(Console.ReadLine());
            var secondNum = sbyte.Parse(Console.ReadLine());

            var sum = firstNum * secondNum;

            Console.WriteLine(sum);
        }
    }
}