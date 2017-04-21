namespace _02.Sign_of_Integer_Number
{
    using System;
    public class SignOfIntegerNumber
    {
        // Create a method that prints the sign of an integer number "n".
        public static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}