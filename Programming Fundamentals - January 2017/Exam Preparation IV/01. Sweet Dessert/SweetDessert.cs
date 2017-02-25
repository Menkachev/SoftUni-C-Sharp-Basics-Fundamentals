namespace _01.Sweet_Dessert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SweetDessert
    {
        public static void Main()
        {
            var cash = double.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var bananasPrice = double.Parse(Console.ReadLine());
            var eggsPrice = double.Parse(Console.ReadLine());
            var berriesPrice = double.Parse(Console.ReadLine());

            var portionsNeded = numberOfGuests / 6;

            if (numberOfGuests % 6 != 0)
            {
                portionsNeded++;
            }
            var totalBananasPrice = portionsNeded * (2 * bananasPrice);
            var totalEggsPrice = portionsNeded * (4 * eggsPrice);
            var totalBerriesPrice = portionsNeded * (0.2 * berriesPrice);

            var totalPrice = totalBananasPrice + totalEggsPrice + totalBerriesPrice;
            var moreMoney = totalPrice - cash;

            if (totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moreMoney:F2}lv more.");
            }
        }
    }
}