namespace P05BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Globalization;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var listOfBooks = new List<Book>();

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                var books = Console.ReadLine()
                    .Split(' ').ToList();

                var bookName = new Book
                {
                    Title = books[0],
                    Author = books[1],
                    Publisher = books[2],
                    ReleaseDate = DateTime.ParseExact(books[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = int.Parse(books[4]),
                    Price = double.Parse(books[5])
                };

                listOfBooks.Add(bookName);
            }

            var library = new Library
            {
                Name = "Library",
                Books = listOfBooks
            };

            var authors = new Dictionary<string, double>();

            foreach (var book in library.Books)
            {
                if (authors.ContainsKey(book.Author))
                {
                    authors[book.Author] += book.Price;
                }
                else
                {
                    authors[book.Author] = book.Price;
                }
            }

            

            foreach (var book in authors.OrderByDescending(p => p.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Value:F2}");
            }
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
