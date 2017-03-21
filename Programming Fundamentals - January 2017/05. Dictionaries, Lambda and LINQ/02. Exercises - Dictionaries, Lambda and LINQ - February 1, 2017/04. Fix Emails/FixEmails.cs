namespace _04.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        //// You are given a sequence of strings, each on a new line, until you receive the “stop” command. 
        //// The first string is the name of a person. On the second line you will receive their email. 

        //// Your task is to collect their names and emails, and remove emails whose domain ends with 
        //// "us" or "uk" (case insensitive). Print: {name} – > {email}

public static void Main()
        {
            var emailAddresses = new Dictionary<string, string>();

            var inputLine = Console.ReadLine();

            while (inputLine != "stop")
            {
                var name = inputLine;
                var email = Console.ReadLine();

                //// In dictionary "emailAddresses" in key "name" we save the value of "email".
                emailAddresses.Add(name, email);

                inputLine = Console.ReadLine();
            }

            //// Remove emails whose domain ends with "us" or "uk" (case insensitive). 
            var fixedEmails = emailAddresses
                .Where(email => !email.Value.ToLower().EndsWith("us") && !email.Value.ToLower().EndsWith("uk"))
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var pair in fixedEmails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}