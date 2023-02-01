using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                    "Promessi Sposi",
                    "Alessandro Manzoni"
                ),
                new Book
                (
                    "Il Signore degli Anelli",
                    "J.R.R. Tolkien"
                ),
                new Book
                (
                    "Harry Potter",
                    "J.Rowling"
                ),
                new Book
                (
                    "Fight Club",
                    "Chuck Pahlaniuk"
                ),
                new Book
                (
                    "Il dracula di Bram Stoker",
                    "Bram Stoker"
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
                }
            }
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public Book GetById(Guid id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }

        public Book GetByName(string title)
        {
            return books.FirstOrDefault(x => x.Title == title);
        }

        public void UpdateById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
