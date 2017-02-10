namespace _07.Sales_Report
{
    using System;
    using System.Collections.Generic;

    public class SalesReport
    {
        //// Write a class Sale holding the following data: town, product, price, quantity. 
        //// Read a list of sales and calculate and print the total sales by town as shown in the output. 
        //// Order alphabetically the towns in the output.

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                //// Reads the parts "n" times in the Console, divided by space ' '.
                var currentSaleParts = Console.ReadLine().Split(' ');

                //// Add the different Sales in each sale part.
                var currentSale = new Sale
                {
                    Town = currentSaleParts[0],
                    Product = currentSaleParts[1],
                    Price = double.Parse(currentSaleParts[2]),
                    Quantity = double.Parse(currentSaleParts[3])
                };

                //// Save the new "currentSale" in a List!
                sales.Add(currentSale);

                //// New Dictionary to check if each part is in!
                var result = new SortedDictionary<string, double>();

                foreach (var sale in sales)
                {
                    if (!result.ContainsKey(sale.Town))
                    {
                        result[sale.Town] = 0;
                    }

                    //// Value "Town" in Key "sale" from Dictionary "result" is:
                    result[sale.Town] += sale.Price * sale.Quantity;
                }

                //// Read each Key and Value from the Dictionary for each town.
                foreach (var keyValuePair in result)
                {
                    Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value:f2}");
                }
            }
        }

        public class Sale
        {
            public double Price { get; set; }

            public string Town { get; set; }

            public string Product { get; set; }

            public double Quantity { get; set; }
        }
    }
}