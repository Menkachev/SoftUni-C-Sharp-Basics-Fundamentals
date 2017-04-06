namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        // Andrey is the guy who gives us food and drinks at the game bar. He likes to play billiard.
        // Since you are nice guy you want to help him play more of his favorite game. You decide to
        // create a program which will help him to take orders faster and generate billing information.

        // First you will receive an integer - the amount of entities with prices(separated by "-").
        // Then you will receive a list of client.For every consumer you will receive what to buy 
        // and how much. When you receive a command: "end of clients" you should display information 
        // about every client described below. After that say how much total money were spent while 
        // Andrey was playing billiard.

        public static void Main(string[] args)
        {
            Dictionary<string, decimal> menu = GetProductsAndPrices();
            List<Customer> customers = GatherOrders(menu);
            PrintTotalBill(menu, customers);
        }

        private static void PrintTotalBill(Dictionary<string, decimal> menu, List<Customer> customers)
        {
            customers = customers
                .OrderBy(x => x.Name)
                .ToList();

            decimal totalBill = 0M;
            foreach (Customer client in customers)
            {
                Console.WriteLine(client.Name);
                foreach (KeyValuePair<string, int> line in client.Order)
                {
                    Console.WriteLine($"-- {line.Key} - {line.Value}");
                }

                decimal bill = client.Bill(menu);
                Console.WriteLine($"Bill: {bill:F2}");
                totalBill += bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        private static List<Customer> GatherOrders(Dictionary<string, decimal> menu)
        {
            List<Customer> customers = new List<Customer>();

            while (true)
            {
                string[] order = Console.ReadLine().Split('-', ',');
                if (order[0].ToLower().Equals("end of clients"))
                {
                    return customers;
                }

                if (menu.ContainsKey(order[1]))
                {
                    if (customers.Any(x => x.Name.Equals(order[0])))
                    {
                        Customer temp = customers.First(x => x.Name.Equals(order[0]));
                        if (temp.Order.ContainsKey(order[1]))
                        {
                            temp.Order[order[1]] += int.Parse(order[2]);
                        }
                        else
                        {
                            temp.Order[order[1]] = int.Parse(order[2]);
                        }
                    }
                    else
                    {
                        customers.Add(
                            new Customer()
                            {
                                Name = order[0],
                                Order = new Dictionary<string, int>()
                                {
                                    { order[1], int.Parse(order[2]) }
                                }
                            });
                    }
                }
            }
        }

        private static Dictionary<string, decimal> GetProductsAndPrices()
        {
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();

            int numberOfProducts = int.Parse(Console.ReadLine()); // Read number of proucts on the console.

            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] newProduct = Console.ReadLine().Split('-'); // Separate the key and value.
                menu[newProduct[0]] = decimal.Parse(newProduct[1]); // Push the key and value in "menu".
            }

            return menu;
        }
    }
}