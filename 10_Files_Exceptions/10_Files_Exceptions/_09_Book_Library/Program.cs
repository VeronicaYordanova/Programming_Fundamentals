using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace _09_Book_Library
{

    public class Book
    {
        public string TitleOfBook { get; set; }
        public string AuthorOfBook { get; set; }
        public string PublisherOfBook { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBNnumber { get; set; }
        public decimal Price { get; set; }

    }

    public class Library
    {
        public string NameLibrary { get; set; }
        public List<Book> ListOfBooks { get; set; }
    }

    class BookLibrary
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();
            myLibrary.ListOfBooks = new List<Book>();

            int countOfBook = int.Parse(Console.ReadLine());

            for (int book = 0; book < countOfBook; book++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                string releaseDate = input[3];
                string iSBN = input[4];
                decimal price = decimal.Parse(input[5]);

                Book myBook = new Book();
                myBook.TitleOfBook = title;
                myBook.AuthorOfBook = author;
                myBook.PublisherOfBook = publisher;
                myBook.ReleaseDate = releaseDate;
                myBook.ISBNnumber = iSBN;
                myBook.Price = price;
                myLibrary.ListOfBooks.Add(myBook);

            }
            Dictionary<string, decimal> filteredBooks = new Dictionary<string, decimal>();
            for (int book = 0; book < myLibrary.ListOfBooks.Count; book++)
            {
                if (!filteredBooks.ContainsKey(myLibrary.ListOfBooks[book].AuthorOfBook))
                {
                    filteredBooks.Add(myLibrary.ListOfBooks[book].AuthorOfBook, 0);

                }
                filteredBooks[myLibrary.ListOfBooks[book].AuthorOfBook] += myLibrary.ListOfBooks[book].Price;

            }
            File.WriteAllText("output.txt", string.Empty);

            foreach (var book in filteredBooks.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                File.AppendAllText("output.txt", $"{book.Key} -> {book.Value:f2}{Environment.NewLine}");
            }

        }
    }
}