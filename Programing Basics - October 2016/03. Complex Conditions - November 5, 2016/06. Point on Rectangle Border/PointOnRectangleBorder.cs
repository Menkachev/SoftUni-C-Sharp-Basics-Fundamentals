namespace _06.Point_on_Rectangle_Border
{
    using System;

    public class PointOnRectangleBorder
    {
        //// Напишете програма, която проверява дали точка {x, y} се намира върху някоя от страните на 
        //// правоъгълник { x1, y1 } – {x2, y2}. Входните данни се четат от конзолата и се състоят от 6 реда: 
        //// десетичните числа x1, y1, x2, y2, x и y (като се гарантира, че x1 < x2 и y1<y2). Да се отпечата 
        //// “Border” (точката лежи на някоя от страните) или “Inside / Outside” (в противен случай). 

        //// Пример: Input: 2, -3, 12, 3, 8, -1 -> Output: Inside / Outside

        ////         Input: 2, -3, 12, 3, 12, -1 -> Output: Border

        public static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            if ((x == x1 || x == x2) && (y1 <= y && y <= y2))
            {
                Console.WriteLine("Border");
            }
            else if ((y == y1 || y == y2) && (x1 <= x && x <= x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}