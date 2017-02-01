namespace _08.Refactor_Volume_of_Pyramid
{
    using System;

    public class RefactorVolumeOfPyramid
    {
        //// You are given a working code that finds the volume of a prism: 

        //// Fix naming, span and multi-purpose variables.

        public static void Main()
        {
            //// First line
            Console.Write("Length: "); 
            var lenght = double.Parse(Console.ReadLine());

            //// Second line
            Console.Write("Width: "); 
            var width = double.Parse(Console.ReadLine());

            //// Third line
            Console.Write("Height: "); 
            var height = double.Parse(Console.ReadLine());

            //// Result
            var volume = (lenght * width * height) / 3; 
            
            Console.WriteLine("Pyramid Volume: {0:f2}", volume);
        }
    }
}