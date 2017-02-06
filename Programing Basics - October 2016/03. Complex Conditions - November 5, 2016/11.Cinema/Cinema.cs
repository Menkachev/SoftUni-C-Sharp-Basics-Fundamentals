namespace _11.Cinema
{
    using System;

    public class Cinema
    {
        //// В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.
        //// Има три вида прожекции с билети на различни цени:

        ////   # Premiere – премиерна прожекция, на цена 12.00 лева.
        ////   # Normal – стандартна прожекция, на цена 7.50 лева.
        ////   # Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

        //// Напишете програма, която въвежда тип прожекция(стринг), брой редове и брой колони в залата
        //// (цели числа) и изчислява общите приходи от билети при пълна зала. Резултатът да се отпечата 
        //// във формат като в примерите по-долу, с 2 знака след десетичната точка.

        //// Пример: Input: Premiere, 10, 12 -> Output: 1440.00 leva

        public static void Main()
        {
            var projection = Console.ReadLine();
            var roll = double.Parse(Console.ReadLine());
            var column = double.Parse(Console.ReadLine());

            var price = 0.0;

            switch (projection)
            {
                case "Premiere":
                    price = (roll * column) * 12;
                    Console.WriteLine("{0:f2}", price);
                    break;
                case "Normal":
                    price = (roll * column) * 7.50;
                    Console.WriteLine("{0:f2}", price);
                    break;
                case "Discount":
                    price = (roll * column) * 5;
                    Console.WriteLine("{0:f2}", price);
                    break;
            }
        }
    }
}