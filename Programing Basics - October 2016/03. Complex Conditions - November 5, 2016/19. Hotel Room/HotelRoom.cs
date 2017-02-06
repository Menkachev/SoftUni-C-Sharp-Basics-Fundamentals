namespace Hotel_Room
{
    using System;

    public class HotelRoom
    {
        //// Трета задача от междинния изпит на 28 август 2016. 

        //// Хотел предлага 2 вида стаи: студио и апартамент. Напишете програма, която изчислява цената за 
        //// целия престой за студио и апартамент. Цените зависят от месеца на престоя:

        //// Май и октомври               |  Юни и септември                 |  Юли и август
        //// Студио – 50 лв./нощувка      |  Студио – 75.20 лв./нощувка      |  Студио – 76 лв./нощувка
        //// Апартамент – 65 лв./нощувка  |  Апартамент – 68.70 лв./нощувка  |  Апартамент – 77 лв./нощувка

        //// Предлагат се и следните отстъпки:
        ////   # За студио, при повече от 7 нощувки през май и октомври : 5% намаление.
        ////   # За студио, при повече от 14 нощувки през май и октомври : 30% намаление.
        ////   # За студио, при повече от 14 нощувки през юни и септември: 20% намаление.
        ////   # За апартамент, при повече от 14 нощувки, без значение от месеца : 10% намаление.

        //// Входът се чете от конзолата и съдържа точно 2 реда:
        ////   # На първия ред е месецът – May, June, July, August, September или October
        ////   # На втория ред е броят на нощувките – цяло число в интервала[0... 200]

        //// Да се отпечатат на конзолата 2 реда:
        ////   # На първия ред: “Apartment: {цена за целият престой} lv.”
        ////   # На втория ред: “Studio: {цена за целият престой} lv.“

        //// Цената за целия престой форматирана с точност до два знака след десетичната запетая.

        //// Пример: Input: May, 15 -> Output: Apartment: 877.50 lv., Studio: 525.00 lv.

        public static void Main()
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    apartmentPrice = 65;
                    studioPrice = 50;
                    if (nights > 7 && nights < 14)
                    {
                        studioPrice -= 50 * 0.05;
                    }
                    else if (nights > 14)
                    {
                        apartmentPrice -= 65 * 0.1;
                        studioPrice -= 50 * 0.3;
                    }

                    break;

                case "June":
                case "September":
                    apartmentPrice = 68.70;
                    studioPrice = 75.20;
                    if (nights > 14)
                    {
                        apartmentPrice -= 68.70 * 0.1;
                        studioPrice -= 75.20 * 0.2;
                    }

                    break;

                case "July":
                case "August":
                    apartmentPrice = 77;
                    studioPrice = 76;
                    if (nights > 14)
                    {
                        apartmentPrice -= 77 * 0.1;
                    }

                    break;
            }

            double totalApartmentPrice = apartmentPrice * nights;
            double totalStudioPrice = studioPrice * nights;

            Console.WriteLine("Apartment: {0:f2} lv.", totalApartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", totalStudioPrice);
        }
    }
}