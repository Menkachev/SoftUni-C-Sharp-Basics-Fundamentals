namespace Problem_04___Bills
{
    using System;

    public class Bills
    {
        public static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            var electricity = 0.0;

            var water = months * 20;
            var internet = months * 15;
            var other = 0.0;
            var average = 0.0;

            for (int i = 0; i < months; i++)
            {
                var current = double.Parse(Console.ReadLine());
                electricity += current;

                var currentOther = current + 20 + 15;
                var totalOther = currentOther + (currentOther * 0.2);
                other += totalOther;
            }

            average = (electricity + water + internet + other) / months;

            Console.WriteLine("Electricity: {0:F2} lv", electricity);
            Console.WriteLine("Water: {0:F2} lv", water);
            Console.WriteLine("Internet: {0:F2} lv", internet);
            Console.WriteLine("Other: {0:F2} lv", other);
            Console.WriteLine("Average: {0:F2} lv", average);
        }
    }
}