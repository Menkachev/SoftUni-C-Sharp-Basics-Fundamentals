namespace _05.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        //// Write a program to read "n" points and find the closest two of them.

        //// Inout
        //// The input holds the number of points "n" and n lines, each holding a point { X and Y coordinate }.

        //// Output
        ////   # The output holds the shortest distance and the closest two points.
        ////   # If several pairs of points are equally close, print the first of them(from top to bottom). 
        
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Points>();

            for (int i = 0; i < n; i++)
            {
                var currentPointParts =
                    Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Points
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]
                });
            }

            var minDistanceSoFar = double.MaxValue;
            Points firstPointMin = null;
            Points secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currentDistance = 
                        CalculateDistance(
                        firstPoint, 
                        secondPoint);

                    if (currentDistance < minDistanceSoFar)
                    {
                        minDistanceSoFar = currentDistance;

                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistanceSoFar:f3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
        }

        //// The Following Method calculates "Euclidean distance". 
        public static double CalculateDistance(Points firstPoint, Points secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }

        public class Points
        {
            public double X { get; set; }

            public double Y { get; set; }
        }
    }
}