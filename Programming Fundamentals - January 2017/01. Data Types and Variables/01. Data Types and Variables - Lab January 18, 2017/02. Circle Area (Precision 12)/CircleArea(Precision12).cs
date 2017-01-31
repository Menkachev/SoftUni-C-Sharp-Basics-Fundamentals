namespace _02.Circle_Area__Precision_12_
{
    using System;

    public class CircleAreaPrecision12
    {
        //// Write program to enter a radius r(real number) and print the area of the circle with 
        //// exactly 12 digits after the decimal point.Use data type of enough precision to hold the results.

        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}", (Math.PI * r) * r);
        }
    }
}