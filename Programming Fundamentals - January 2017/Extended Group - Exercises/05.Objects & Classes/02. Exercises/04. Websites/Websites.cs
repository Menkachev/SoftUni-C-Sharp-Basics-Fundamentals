namespace _04.Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Websites
    {
        public static void Main(string[] args)
        {
            List<Website> websites = new List<Website>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var tokens = inputLine
                    .Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (tokens.Length > 2)
                {
                    string host = tokens[0];
                    string domain = tokens[1];
                    List<string> queries = tokens.Skip(2).ToList();

                    Website newWebsites = new Website();

                    newWebsites.Host = host;
                    newWebsites.Domain = domain;
                    newWebsites.Query = queries;

                    websites.Add(newWebsites);
                }
                else
                {
                    string host = tokens[0];
                    string domain = tokens[1];

                    Website newWebsites = new Website();

                    newWebsites.Host = host;
                    newWebsites.Domain = domain;

                    websites.Add(newWebsites);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                if (website.Query != null)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[{string.Join("]&[", website.Query)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }
        }
    }
}