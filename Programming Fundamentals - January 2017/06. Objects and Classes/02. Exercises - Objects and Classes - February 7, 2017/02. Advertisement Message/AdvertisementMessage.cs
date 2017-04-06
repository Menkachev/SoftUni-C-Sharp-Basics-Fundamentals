namespace _02.Advertisement_Message
{
    using System;
    using System.Collections.Generic;

    public class AdvertisementMessage
    {
        //// Write a program that generate random fake advertisement message to extol some product. 
        //// The messages must consist of 4 parts: laudatory phrase + event + author + city. Use the 
        //// following predefined parts:

        ////   # Phrases – {“Excellent product.”, “Such a great product.”, “I always use that product.”, 
        ////               “Best product of its category.”, “Exceptional product.”, 
        ////               “I can’t live without this product.”}

        ////   # Events – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. 
        ////              I am happy of the results!”, “I cannot believe but now I feel awesome.”, 
        ////              ”Try it yourself, I am very satisfied.”, “I feel great!”}

        ////   # Author – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}

        ////   # Cities – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}

        //// The format of the output message is: { phrase} {event} {author} – {city}.

        //// As an input you take the number of messages to be generated. Print each random message 
        //// at a separate line.

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new List<string>()
                {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var author = new List<string>()
                {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            var random = new Random();

            for (int i = 0; i < n; i++)
            {
                var currentPhrase = phrases[random.Next(0, phrases.Count)];
                var currentEvent = events[random.Next(0, events.Count)];
                var currentAuthor = author[random.Next(0, author.Count)];
                var currentCity = cities[random.Next(0, cities.Count)];

                Console.WriteLine($"{currentPhrase} {currentEvent} {currentAuthor} - {currentCity}");
            }
        }
    }
}