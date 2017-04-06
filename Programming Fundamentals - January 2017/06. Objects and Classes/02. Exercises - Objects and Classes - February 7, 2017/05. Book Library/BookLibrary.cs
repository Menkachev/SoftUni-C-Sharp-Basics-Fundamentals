namespace _05.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibrary
    {
        // To model a book library, define classes to hold a book and a library. 
        // The library must have a name and a list of books. The books must contain 
        // the title, author, publisher, release date, ISBN-number and price. 

        // Read a list of books, add them to the library and print the total sum of prices by author,
        // ordered descending by price and then by author’s name lexicographically.

        // Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.

        public static void Main()
        {
            Library gatheredBooks = FillLibrary();
            PrintPricesByAuthor(gatheredBooks);
        }

        private static void PrintPricesByAuthor(Library gatheredBooks)
        {
            Dictionary<string, double> moneyByAuthor = new Dictionary<string, double>();

            foreach (Book book in gatheredBooks.Books)
            {
                if (moneyByAuthor.ContainsKey(book.Author))
                {
                    moneyByAuthor[book.Author] += book.Price;
                }
                else
                {
                    moneyByAuthor[book.Author] = book.Price;
                }
            }

            moneyByAuthor = moneyByAuthor
                    .OrderByDescending(x => x.Value) // Ordered descending by price, 
                    .ThenBy(x => x.Key) // then by author’s name lexicographically.
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, double> author in moneyByAuthor)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }

        private static Library FillLibrary()
        {
            // Create new "Library" with "Name" and List of "Book".
            Library gatherBooks = new Library { Name = "gatheredBooks", Books = new List<Book>() };
            // Read the number of the books in the input.
            int numberOfBooks = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] bookData = Console.ReadLine().Split(' ');

                // {title} {author} {publisher} {release date} {ISBN} {price}
                Book temp = new Book(
                    bookData[0],
                    bookData[1],
                    bookData[2],
                    DateTime.ParseExact(bookData[3], "d.M.yyyy", CultureInfo.InvariantCulture),
                    bookData[4],
                    double.Parse(bookData[5]));

                // Add the new books data in the list.
                gatherBooks.Books.Add(temp);
            }

            return gatherBooks;
        }
    }
}