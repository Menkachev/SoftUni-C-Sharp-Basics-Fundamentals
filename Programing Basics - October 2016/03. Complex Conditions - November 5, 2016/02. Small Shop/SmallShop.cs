namespace Small_Shop
{
    using System;

    public class SmallShop
    {
        //// Предприемчив българин отваря квартални магазинчета в няколко града и продава на различни цени:

        //// град / продукт | coffee | water | beer | sweets | peanuts
        //// Sofia          | 0.50   | 0.80  | 1.20	|  1.45	 |  1.60
        //// Plovdiv        | 0.40   | 0.70	 | 1.15	|  1.30	 |  1.50
        //// Varna          | 0.45   | 0.70  | 1.10	|  1.35	 |  1.55

        //// Напишете програма, която чете от конзолата град (стринг), продукт (стринг) и количество
        //// (десетично число) и пресмята и отпечатва колко струва съответното количество от избрания 
        //// продукт в посочения град.

        //// Пример: Input: water, Plovdiv, 3 -> Output: 2.1

        public static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.5 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.8 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.2 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.45 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.6 * quantity);
                }
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.4 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.15 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.3 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.5 * quantity);
                }
            }
            else if (city == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.45 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.1 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.35 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }
        }
    }
}