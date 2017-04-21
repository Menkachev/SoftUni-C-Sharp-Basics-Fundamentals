namespace _10.Cube_Properties
{
    using System;

    public class CubeProperties
    {
        // Write a program that can calculate the length of the face diagonals, 
        // space diagonals, volume and surface area of a cube by a given side. 
        // On the first line you will get the side of the cube. On the second 
        // line is given the parameter (face, space, volume or area).

        // Output should be rounded to the second digit after the decimal point

        // Examples: Input: 5, face -> Output: 7,07     Input: 5, volume -> Output: 125.00

        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            string figure = Console.ReadLine();

            if (figure == "face")
            {
                Console.WriteLine("{0:f2}", Math.Sqrt(2 * (side * side)));
            }
            else if (figure == "space")
            {
                Console.WriteLine("{0:f2}", Math.Sqrt(3 * (side * side)));
            }
            else if (figure == "volume")
            {
                Console.WriteLine("{0:f2}", side * side * side);
            }
            else if (figure == "area")
            {
                Console.WriteLine("{0:f2}", 6 * (side * side));
            }
        }
    }
}