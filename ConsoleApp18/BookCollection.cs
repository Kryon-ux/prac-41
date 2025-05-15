using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class BookCollection
    {
        public Book[] Books { get; set; }

        public BookCollection(Book[] books)
        {
            Books = books;
        }

        public void SortBooks(Book.BookComparer comparer)
        {
            Array.Sort(Books, new Comparison<Book>((b1, b2) => comparer(b1, b2)));
        }

        public void DisplayBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }
    }

}
