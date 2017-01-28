namespace Area_of_Figures
{
    using System;

    public class AreaOfFigures
    {
        //// Да се напише програма, която въвежда размерите на геометрична фигура и пресмята лицето й.
        //// Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle). 
        //// На първия ред на входа се чете вида на фигурата(square, rectangle, circle или triangle). 
        //// Ако фигурата е квадрат, на следващия ред се чете едно число – дължина на страната му.
        //// Ако фигурата е правоъгълник, на следващите два реда четат две числа – дължините на страните му.
        //// Ако фигурата е кръг, на следващия ред чете едно число – радиусът на кръга.Ако фигурата е триъгълник,
        //// на следващите два реда четат две числа – дължината на страната му и дължината на височината към нея.
        //// Резултатът да се закръгли до 3 цифри след десетичната точка.

        public static void Main()
        {
            var square = double.Parse(Console.ReadLine());
            var rectangle = double.Parse(Console.ReadLine());
            var circle = double.Parse(Console.ReadLine());
            var triangle = double.Parse(Console.ReadLine());

            var input = Console.ReadLine();
            var squareSize = square * 2;
            var daljina1 = double.Parse(Console.ReadLine());
            var daljina2 = double.Parse(Console.ReadLine());
            var rectangleSize = daljina1 * daljina2;
            var circleSize = circle * 3.14;
            var daljina = double.Parse(Console.ReadLine());
            var visochina = double.Parse(Console.ReadLine());
            var triangleSize = daljina * visochina / 2;
            
            if (input == "square")
            {
                Console.WriteLine(squareSize);
            }
            else if (input == "rectangle")
            { 
                Console.WriteLine(rectangleSize);
            }
            else if (input == "circle")
            {
                Console.WriteLine(circleSize);
            }
            else if (input == "triangle")
            {
                Console.WriteLine(triangleSize);
            }
        }
    }
}