namespace _04.Exam_Shopping
{
    using System;
    using System.Collections.Generic;

    public class ExamShopping
    {
        public static void Main(string[] args)
        {
            var products = new Dictionary<string, int>();

            var inventory = Console.ReadLine();

            while (inventory != "shopping time")
            {
                // Read the product under [1] index and the quantity under [2] index.
                var tokens = inventory.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    products[product] = 0;
                }
                // Count the quantity of the product.
                products[product] += quantity;

                // Read the input.
                inventory = Console.ReadLine();
            }

            // read the input again.
            inventory = Console.ReadLine();

            while (inventory != "exam time")
            {
                // Use the upper logic.
                var tokens = inventory.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                { 
                    // If the product is 0 then it's out of stock.
                    if (products[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        // Subtract quantity from the product for what is left.
                        products[product] -= quantity;

                        //  Less than 0, it is 0 => out of stock.
                        if (products[product] < 0)
                        {
                            products[product] = 0;
                        }
                    }
                }
                // Read the input.
                inventory = Console.ReadLine();
            }

            foreach (var productQuantityPair in products)
            {
                var product = productQuantityPair.Key;
                var quantity = productQuantityPair.Value;

                // Need to be bigger than 0.
                if (quantity > 0)
                {
                    Console.WriteLine($"{product} -> {quantity}");
                }
            }
        }
    }
}