namespace _06.Book_Library_Modification
{
    using System;

    public class Book
    {
        public string Title, Author, Publisher, ISBN;
        public DateTime ReleaseDate;
        public double Price;

        public Book(
            string title,
            string author,
            string publisher,
            DateTime releaseDate,
            string isbn,
            double price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;
        }
    }
}