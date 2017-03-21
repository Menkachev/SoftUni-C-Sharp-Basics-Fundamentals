namespace _05.User_Logins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserLogins
    {
        public static void Main(string[] args)
        {
            var userEntries = new Dictionary<string, string>();

            var users = Console.ReadLine();

            while (users != "login")
            {
                var line = users.Split();
                var username = line[0];
                var password = line[2];

                if (userEntries.ContainsKey(username))
                {
                    userEntries[password] = password;
                }

                users = Console.ReadLine();
            }

            users = Console.ReadLine();
            while (users != "end")
            {
                var line = users.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var username = line[0];
                var password = line[2];

                if (!userEntries.ContainsValue(username))
                {
                    //if (userEntries.ContainsValue(password))
                    //{
                    //  Console.WriteLine($"{username}: login failed");
                    //}
                    //else
                    //{
                    Console.WriteLine($"{username}: login failed");
                    //}
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }

                users = Console.ReadLine();
            }

            Console.WriteLine();

            //foreach (var userEntryPassword in userEntries)
            //{
            //    var user = userEntryPassword.Key;
            //    var password = userEntryPassword.Value;

            //    Console.WriteLine($"");
            //}
        }
    }
}