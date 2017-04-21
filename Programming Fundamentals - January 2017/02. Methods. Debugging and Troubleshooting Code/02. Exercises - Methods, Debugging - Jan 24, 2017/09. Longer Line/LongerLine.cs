namespace _09.Longer_Line
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double x1y1 = Math.Sqrt(x1 * x1) + (y1 * y1);
            double x2y2 = Math.Sqrt(x2 * x2) + (y2 * y2);

            double x3y3 = Math.Sqrt(x3 * x3) + (y3 * y3);
            double x4y4 = Math.Sqrt(x4 * x4) + (y4 * y4);

            if (x1y1 < x3y3 && x2y2 < x4y4)
            {
                if (x3y3 <= x4y4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
            else
            {
                if (x1y1 <= x2y2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
        }
    }
}