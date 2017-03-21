namespace _06.Filter_Base
{
    using System;
    using System.Collections.Generic;

    public class FilterBase
    {
        public static void Main(string[] args)
        {
            var employesAge = new Dictionary<string, int>();
            var employesSalary = new Dictionary<string, double>();
            var employesPosition = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "filter base")
            {
                var tokens = input.Split();
                var name = tokens[0];
                var condition = tokens[2];

                employesPosition[name] = condition;

                var ageNumber = 0;
                if (int.TryParse(condition, out ageNumber))
                {
                    employesAge[name] = ageNumber;
                }

                var salaryNumber = 0.0;
                if (double.TryParse(condition, out salaryNumber))
                {
                    employesSalary[name] = salaryNumber;
                }

                input = Console.ReadLine();
            }

            var secondInput = Console.ReadLine();

            if (secondInput == "Age")
            {
                foreach (var name in employesAge)
                {
                    var employee = name.Key;
                    var age = name.Value;

                    Console.WriteLine($"Name: {employee}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine(new string('=', 20));
                }
            }

            else if (secondInput == "Salary")
            {
                foreach (var name in employesSalary)
                {
                    var employee = name.Key;
                    var salary = name.Value;

                    Console.WriteLine($"Name: {employee}");
                    Console.WriteLine($"Salary: {salary}");
                    Console.WriteLine(new string('=', 20));
                }
            }

            else if (secondInput == "Position")
            {
                foreach (var name in employesPosition)
                {
                    var employee = name.Key;
                    var position = name.Value;

                    Console.WriteLine($"Name: {employee}");
                    Console.WriteLine($"Position: {position}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}