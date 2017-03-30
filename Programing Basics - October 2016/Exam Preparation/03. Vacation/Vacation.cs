namespace _03.Vacation
{
    using System;

    public class Vacation
    {
        public static void Main(string[] args)
        {
            var oldPeople = double.Parse(Console.ReadLine());
            var youngPeople = double.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var transportPrice = 0.0;

            var nightsPrice = nights * 82.99;

            if (transport == "train")
            {
                if (oldPeople + youngPeople >= 50)
                {
                    oldPeople = oldPeople * (24.99 - (24.99 * 0.5)) * 2;
                    youngPeople = youngPeople * (14.99 - (14.99 * 0.5)) * 2;
                    transportPrice = oldPeople + youngPeople;
                }
                else
                {
                    oldPeople = (oldPeople * 24.99) * 2;
                    youngPeople = (youngPeople * 14.99) * 2;
                    transportPrice = oldPeople + youngPeople;
                }
            }
            else if (transport == "bus")
            {
                oldPeople = (oldPeople * 32.50) * 2;
                youngPeople = (youngPeople * 28.50) * 2;
                transportPrice = oldPeople + youngPeople;
            }
            else if (transport == "boat")
            {
                oldPeople = (oldPeople * 42.99) * 2;
                youngPeople = (youngPeople * 39.99) * 2;
                transportPrice = oldPeople + youngPeople;
            }
            else if (transport == "airplane")
            {
                oldPeople = (oldPeople * 70.00) * 2;
                youngPeople = (youngPeople * 50.00) * 2;
                transportPrice = oldPeople + youngPeople;
            }

                    var sum = transportPrice + nightsPrice;
                    var commission = sum * 0.10;

                    Console.WriteLine("{0:f2}", sum + commission);
            }
        }
    }