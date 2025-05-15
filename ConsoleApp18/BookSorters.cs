using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public static class BookSorters
    {
        public static int CompareByTitle(Book b1, Book b2)
        {
            return string.Compare(b1.Title, b2.Title);
        }

        public static int CompareByAuthor(Book b1, Book b2)
        {
            return string.Compare(b1.Author, b2.Author);
        }

        public static int CompareByPublisher(Book b1, Book b2)
        {
            return string.Compare(b1.Publisher, b2.Publisher);
        }
    }
}
