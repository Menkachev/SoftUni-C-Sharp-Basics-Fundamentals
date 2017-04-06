namespace _06.Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibraryModification
    {
            // Use the classes from the previous problem and make a program that read 
            // a list of books and print all titles released after given date ordered by date 
            // and then by title lexicographically. The date is given if format “day-month-year” 
            // at the last line in the input.

            public static void Main()
            {
                Library library = FillLibrary();
                PrintAuthorAfterGivenDate(library);
            }

        private static void PrintAuthorAfterGivenDate(Library library)
        {
            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();

            foreach (Book book in library.Books)
            {
                result[book.Title] = book.ReleaseDate;
            }

            PrintTheResult(result);
        }

        private static void PrintTheResult(Dictionary<string, DateTime> result)
        {
            // Read the given date.
            DateTime initialDate = DateTime.ParseExact(
                Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            result = result
                .OrderBy(x => x.Value) // Books ordered by date, 
                .ThenBy(x => x.Key) // then by title lexicographically,
                .Where(x => x.Value > initialDate) // and released after given date.
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(
                string.Join(
                    "\n",
                    result.Select(x => x.Key + " -> " + x.Value.ToString("dd.MM.yyy"))));

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