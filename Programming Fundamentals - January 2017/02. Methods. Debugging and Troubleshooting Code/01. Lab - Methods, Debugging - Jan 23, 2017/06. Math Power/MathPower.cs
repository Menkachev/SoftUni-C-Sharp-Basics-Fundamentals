namespace _06.Math_Power
{
    using System;
    public class MathPower
    {
        // Create a method that calculates and returns 
        // the value of a number raised to a given power.

        // Example: Input: 2, 8 -> Output: 256
        public static double RaiseToPower(double number, double power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            return result;
        }
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }
    }
}