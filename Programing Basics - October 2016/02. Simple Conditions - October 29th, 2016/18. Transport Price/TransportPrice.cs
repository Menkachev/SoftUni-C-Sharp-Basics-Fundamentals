namespace _02.Transport_Price
{
    using System;

    public class TransportPrice
    {
                             //// Втора задача от междинния изпит на 6 март 2016.

        //// Студент трябва да пропътува n километра.Той има избор измежду три вида транспорт:
        ////     ->Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
        ////     ->Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
        ////     ->Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.
        //// Напишете програма, която въвежда броя километри n и период от деня(ден или нощ) 
        //// и изчислява цената на най-евтиния транспорт.

        public static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();

            var taxiRate = 0.90;

            if (dayOrNight == "day")
            {
                taxiRate = 0.79;
            }

            if (distance < 20)
            {
                Console.WriteLine(0.70 + (taxiRate * distance));
            }
            else if (distance < 100)
                {
                Console.WriteLine(distance * 0.09);
            }
            else
            {
                Console.WriteLine(distance * 0.06);
            }
        }  
    }
}