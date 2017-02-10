namespace _04.Distance_between_Points
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        //// Write a method to calculate the distance between two points p1 {x1, y1} and p2 {x2, y2}. 
        //// Write a program to read two points(given as two integers) and print the Euclidean distance 
        //// between them.

        public static void Main()
        {
            var firstPointParts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var firstPoint = new Point
            {
                X = firstPointParts[0],
                Y = firstPointParts[1]
            };

            var secondPointParts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var secondPoint = new Point
            {
                X = secondPointParts[0],
                Y = secondPointParts[1]
            };

            var result = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }

        //// The Following Method calculates "Euclidean distance". 
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }

        public class Point
        {
            public double X { get; set; }

            public double Y { get; set; }
        }
    }
}