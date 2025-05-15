using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
            new Book("C# для начинающих", "Иванов", "Издательство 1"),
            new Book("Алгоритмы и структуры данных", "Петров", "Издательство 2"),
            new Book("Программирование C#", "Сидоров.", "Издательство 3"),
            new Book("Основы c#", "Максимов", "Издательство 4")
            };

            BookCollection bookCollection = new BookCollection(books);

            Console.WriteLine("Сортировка по названию:");
            bookCollection.SortBooks(BookSorters.CompareByTitle);
            bookCollection.DisplayBooks();

            Console.WriteLine("\nСортировка по автору:");
            bookCollection.SortBooks(BookSorters.CompareByAuthor);
            bookCollection.DisplayBooks();

            Console.WriteLine("\nСортировка по издательству:");
            bookCollection.SortBooks(BookSorters.CompareByPublisher);
            bookCollection.DisplayBooks();
            Console.ReadKey();
        }
    }

}
