using System.Collections.Generic;

namespace _03.Circles_Intersection
{
    public class Circle
    {
        public Point Center { get; set; }

        public double Radius { get; set; }

        public bool Intersect(Circle circle)
        {
            return this.Center.Distance(circle.Center) <= circle.Radius + this.Radius;
        }
    }
}
