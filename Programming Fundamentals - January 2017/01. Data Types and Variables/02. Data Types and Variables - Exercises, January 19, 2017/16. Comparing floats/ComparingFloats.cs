namespace _16.Comparing_floats
{
    using System;

    public class ComparingFloats
    {
        //// Write a program that safely compares floating-point numbers(double) 
        //// with precision eps = 0.000001. Note that we cannot directly compare 
        //// two floating-point numbers "a" and "b" by "a==b" because of the nature 
        //// of the floating-point arithmetic.Therefore, we assume two numbers are equal 
        //// if they are more closely to each other than some fixed constant eps. 

        public static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double epsPercision = 0.000001;

            double differenceNumAnumB = Math.Abs(numberA - numberB);

            if (differenceNumAnumB <= epsPercision)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
