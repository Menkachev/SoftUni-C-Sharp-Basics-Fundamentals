namespace _08.Center_Point
{
    using System;

    public class CenterPoint
    {
        // You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2.
        // Create a method that prints the point that is closest to the center of the coordinate system(0, 0)
        // in the format(X, Y). If the points are on a same distance from the center, print only the first one.

        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x1y1 = Math.Sqrt(x1 * x1) + (y1 * y1);
            double x2y2 = Math.Sqrt(x2 * x2) + (y2 * y2);

            if (x1y1 <= x2y2)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
    }
}