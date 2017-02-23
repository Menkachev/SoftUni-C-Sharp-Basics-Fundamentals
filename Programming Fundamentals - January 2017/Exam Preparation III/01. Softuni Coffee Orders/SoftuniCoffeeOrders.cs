namespace _01.Softuni_Coffee_Orders
{
    using System;
    using System.Globalization;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                var capsulePrice = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var currentPrice = (daysInMonth * capsulesCount) * capsulePrice;

                totalPrice += currentPrice;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            }
            
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}