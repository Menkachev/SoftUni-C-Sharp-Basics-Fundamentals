namespace _11.Geometry_Calculator
{
    using System;

    public class GeometryCalculator
    {
        //  Write a program that can calculate the area of four different geometry figures 
        //  - triangle, square, rectangle and circle. On the first line you will get the figure type. 
        //  Next you will get parameters for the chosen figure, each on a different line:
        //     # Triangle - side and height
        //     # Square - side
        ////     # Rectangle - width and height
        //     # Circle - radius

        // Example: Input: triangle, 3, 6 -> Output: 9.00

        public static void Main()
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", (side * height) / 2);
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", side * side);
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", width * height);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", Math.PI * (r * r));
            }
        }
    }
}