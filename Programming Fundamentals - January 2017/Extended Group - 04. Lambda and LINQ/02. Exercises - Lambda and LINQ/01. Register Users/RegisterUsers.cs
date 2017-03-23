namespace _01.Register_Users
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class RegisterUsers
    {
        public static void Main(string[] args)
        {
            Dictionary<string, DateTime> registeredUsers = new Dictionary<string, DateTime>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string userName = inputParams[0];
                DateTime date = DateTime.ParseExact(inputParams[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                registeredUsers[userName] = date;

                inputLine = Console.ReadLine();
            }

            Dictionary<string, DateTime> orderedUsersList = registeredUsers
                .Reverse()
                .OrderBy(u => u.Value)
                .Take(5)
                .OrderByDescending(u => u.Value)
                .ToDictionary(u => u.Key, u => u.Value);

            foreach (var user in orderedUsersList)
            {
                Console.WriteLine(user.Key);
            }  
        }
    }
}