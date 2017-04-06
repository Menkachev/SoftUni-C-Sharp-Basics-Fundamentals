using System;

namespace _03.Circles_Intersection
{
    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(this.X - point.X, 2) + Math.Pow(point.X - this.Y, 2));
        }
    }
}
