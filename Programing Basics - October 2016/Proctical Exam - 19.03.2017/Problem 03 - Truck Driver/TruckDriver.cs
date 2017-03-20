namespace Problem_03___Truck_Driver
{
    using System;

    public class TruckDriver
    {
        // Задача 3. Шофьор на ТИР

        // Напишете програма която пресмята колко пари ще изкара шофьор на ТИР за един сезон.
        // На входа програмата получава през кой сезон ще работи шофьора, както и колко километра 
        // на месец ще кара. Един сезон е 4 месеца. Според зависи сезона и броя километри на месец 
        // ще му се заплаща различна сума на километър:

        //                              | Пролет/Есен |    Лято    | Зима
        // км на месец <= 5000          | 0.75 лв/км  | 0.90 лв/км | 1.05 лв/км
        // 5000 < км на месец <= 10000  | 0.95 лв/км  | 1.10 лв/км | 1.25 лв/км
        // 10000 < км на месец <= 20000 | 1.45 лв/км – за който и да е сезон

        // След като са извадени 10% за данъци се отпечатват останалите пари.

        // Вход:
        // Входът се чете от конзолата и се състои от два реда:
        // •	Първи ред – Сезон – текст "Spring", "Summer", "Autumn" или "Winter"
        // •	Втори ред –  Километри на месец – реално число в интервала [10.00...20000.00]

        // Изход:
        // На конзолата трябва да се отпечатат едно число:
        // •	Заплатата на шофьора след данъците, 
        // форматирана до втория знак след десетичната запетая.

        public static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonth = double.Parse(Console.ReadLine());

            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    kmPerMonth *= 0.75;
                }
                else if (5000 < kmPerMonth && kmPerMonth <= 10000)
                {
                    kmPerMonth *= 0.95;
                }
                else if (10000 < kmPerMonth && kmPerMonth <= 20000)
                {
                    kmPerMonth *= 1.45;
                }
            }
            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    kmPerMonth *= 0.90;
                }
                else if (5000 < kmPerMonth && kmPerMonth <= 10000)
                {
                    kmPerMonth *= 1.10;
                }
                else if (10000 < kmPerMonth && kmPerMonth <= 20000)
                {
                    kmPerMonth *= 1.45;
                }
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    kmPerMonth *= 1.05;
                }
                else if (5000 < kmPerMonth && kmPerMonth <= 10000)
                {
                    kmPerMonth *= 1.25;
                }
                else if (10000 < kmPerMonth && kmPerMonth <= 20000)
                {
                    kmPerMonth *= 1.45;
                }
            }

            var sallary = kmPerMonth * 4;
            var totalSallary = sallary - (sallary / 10);

            Console.WriteLine("{0:F2}", totalSallary);
        }
    }
}