namespace _12.Rectangle_Properties
{
    using System;

    public class RectangleProperties
    {
        //// Create a program to calculate rectangle’s perimeter, 
        //// area and diagonal by given its width and height.

        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var rectanglePerimeter = (2 * width) + (2 * height);
            var rectangleArea = width * height;
            var rectangleDiagonal = Math.Sqrt((width * width) + (height * height));

            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(rectangleArea);
            Console.WriteLine(rectangleDiagonal);
        }
    }
}