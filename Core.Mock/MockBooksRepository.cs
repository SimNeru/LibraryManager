using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mock
{
    public class MockBooksRepository : IRepository<Book>
    {
        public List<Book> books;

        public MockBooksRepository()
        {
            this.books = new List<Book> {
                new Book
                (
                    Guid.NewGuid(),
                    "Promessi Sposi",
                    "Alessandro Manzoni",
                    true
                ),
                new Book
                (
                    Guid.NewGuid(),
                    "Il Signore degli Anelli",
                    "J.R.R. Tolkien",
                    true
                ),
                new Book
                (
                    Guid.NewGuid(),
                    "Harry Potter",
                    "J.Rowling",
                    true
                ),
                new Book
                (
                    Guid.NewGuid(),
                    "Fight Club",
                    "Chuck Pahlaniuk",
                    true
                ),
                new Book
                (
                    Guid.NewGuid(),
                    "Il dracula di Bram Stoker",
                    "Bram Stoker",
                    true
                )
            };
        }

        public void Create(Book book)
        {
            if (books.Any(x => x.Title == book.Title && x.Author == book.Author))
                throw new ArgumentException("Book is already present in our archives");
            books.Add(book);
        }

        public void DeleteAll()
        {
            books = new List<Book>();
        }

        public void DeleteById(Guid id)
        {
            foreach (var item in books)
            {
                if (item.Id == id) 
                {
                    books.Remove(item);
                    Console.WriteLine(item.ToString()+" removed");
                }
            }
        }

        public Book GetById(Guid id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }

        public Book GetByTitle(string title)
        {
            return books.FirstOrDefault(x => x.Title == title);
        }

        public Book UpdateById(Book book)
        {
            var storedId = book.Id;
            var bookUpdated = books.FirstOrDefault(x => x.Id == book.Id);
            return book;
        }
    }
}
