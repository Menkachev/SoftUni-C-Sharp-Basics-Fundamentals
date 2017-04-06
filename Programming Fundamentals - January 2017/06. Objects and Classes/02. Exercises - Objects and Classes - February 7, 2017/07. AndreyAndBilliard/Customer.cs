namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> Order { get; set; }

        public decimal Bill(Dictionary<string, decimal> menu)
        {
            decimal bill = 0M;

            foreach (KeyValuePair<string, int> item in this.Order)
            {
                if (menu.ContainsKey(item.Key))
                {
                    bill += menu[item.Key] * item.Value;
                }
            }

            return bill;
        }
    }
}