using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace _10_Book_Library
{

    public class Book
    {
        public string TitleOfBook { get; set; }
        public string AuthorOfBook { get; set; }
        public string PublisherOfBook { get; set; }
        public DateTime ReleaseDate { get; set; }
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
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
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


            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> filteredBooks = new Dictionary<string, DateTime>();
            for (int book = 0; book < myLibrary.ListOfBooks.Count; book++)
            {
                if (!filteredBooks.ContainsKey(myLibrary.ListOfBooks[book].TitleOfBook))
                {
                    filteredBooks.Add(myLibrary.ListOfBooks[book].TitleOfBook, myLibrary.ListOfBooks[book].ReleaseDate);

                }
                else
                {
                    filteredBooks[myLibrary.ListOfBooks[book].TitleOfBook] = myLibrary.ListOfBooks[book].ReleaseDate;
                }


            }
            File.WriteAllText("output.txt", string.Empty);

            foreach (var book in filteredBooks.Where(x => x.Value > givenDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
               // Console.WriteLine("{0:f2} -> {1:f2}", book.Key, book.Value.ToString("dd.MM.yyyy"));
                File.AppendAllText("output.txt", $"{book.Key:f2} -> {book.Value.ToString("dd.MM.yyyy"):f2}{Environment.NewLine}");
            }

        }
    }
}