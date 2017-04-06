namespace _03.Circles_Intersection
{
    using System;
    using System.Linq;

    public class CirclesIntersection
    {
        //// Create class Circle with properties Center and Radius. The center is a point with coordinates X 
        //// and Y(make a class Point). Write a method bool Intersect(Circle c1, Circle c2) that tells whether 
        //// the two given circles intersect or not. Write a program that tells if two circles intersect.

        //// The input lines will be in format: {X} {Y} {Radius}. Print as output “Yes” or “No”.

        public static void Main()
        {
            Circle firstCirc = GetInputAndSetCirc();
            Circle secondCirc = GetInputAndSetCirc();

            Console.WriteLine(firstCirc.Intersect(secondCirc) ? "Yes" : "No");
        }

        private static Circle GetInputAndSetCirc()
        {
            Circle result = new Circle();
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            result.Center = new Point() { X = input[0], Y = input[1] };
            result.Radius = input[2];
            return result;
        }
    }
}