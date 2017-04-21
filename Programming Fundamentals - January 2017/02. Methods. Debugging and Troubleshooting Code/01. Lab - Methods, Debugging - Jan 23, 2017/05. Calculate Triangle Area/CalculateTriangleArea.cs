namespace _05.Calculate_Triangle_Area
{
    using System;
    public class CalculateTriangleArea
    {
        // Create a method that calculates and returns the area 
        // of a triangle by given width and height.
        public static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTriangleArea(width, height));
        }
    }
}