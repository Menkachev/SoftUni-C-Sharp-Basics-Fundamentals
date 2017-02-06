namespace Point_in_Rectangule
{
    using System;

    public class PointInRectangule
    {
        //// Напишете програма, която проверява дали точка {x, y} се намира вътре в правоъгълник 
        //// {x1, y1} – {x2, y2}. Входните данни се четат от конзолата и се състоят от 6 реда: 
        //// десетичните числа x1, y1, x2, y2, x и y (като се гарантира, че x1 < x2 и y1<y2). 
        //// Една точка е вътрешна за даден правоъгълник, ако се намира някъде във вътрешността му 
        //// или върху някоя от страните му. Отпечатайте “Inside” или “Outside”. 

        //// Пример: Input: 2, -3, 12, 3, 11, -3.5 -> Output: Outside

        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}