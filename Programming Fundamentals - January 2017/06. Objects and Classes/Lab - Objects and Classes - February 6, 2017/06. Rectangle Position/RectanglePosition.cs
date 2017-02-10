namespace _06.Rectangle_Position
{
    using System;
    using System.Linq;

    public class RectanglePosition
    {
        //// Write a program to read two rectangles {left, top, width, height} and print whether the first 
        //// is inside the second. The input is given as two lines, each holding a rectangle, described by 
        //// 4 integers: left, top, width and height.

        public static void Main()
        {
            var first = new Rectangle();
            var second = new Rectangle();

            var inputLineRectangles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var rect = new Rectangle
            {
                Height = inputLineRectangles[0],
                Left = inputLineRectangles[1],
                Top = inputLineRectangles[2],
                Width = inputLineRectangles[3]
            };

            inputLineRectangles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var result = IsInside(first, second);

            if (!result)
            {
                Console.WriteLine("Not Inside");
            }
            else
            {
                Console.WriteLine("Inside");
            }
        }

        public static bool IsInside(Rectangle first, Rectangle second)
        {
            var leftIsCorrect = first.Left >= second.Left;
            var rightIsCorrect = first.Right <= second.Right;
            var topIsCorrect = first.Top <= second.Top;
            var bottomIsCorrect = first.Bottom <= second.Bottom;

            return leftIsCorrect && rightIsCorrect && topIsCorrect && bottomIsCorrect;
        }

        public class Rectangle
        {
            public double Top { get; set; }

            public double Left { get; set; }

            public double Width { get; set; }

            public double Height { get; set; }

            public double Bottom => Top - Height;

            public double Right => Left + Width;
        }
    }
}