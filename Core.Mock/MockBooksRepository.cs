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

        public MockBooksRepository() { 
        this.books = new List<Book> {
            new Book
            { 
                Id = Guid.NewGuid(),
                Title = "Promessi Sposi",
                Author = "Manzoni",
                Availability = true
            },
            new Book
            (
                Id = Guid.NewGuid(),
                Title = "Signore degli Anelli",
                Author = "J.R.R. Tolkien",
                Availability = true
            )
            new Book
            (
                Id = Guid.NewGuid(),
                Title = "Signore degli Anelli",
                Author = "J.R.R. Tolkien",
                Availability = true
            )
            new Book
            (
                Id = Guid.NewGuid(),
                Title = "Signore degli Anelli",
                Author = "J.R.R. Tolkien",
                Availability = true
            )
           } 

        public void Create(Book value)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Book GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Book GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
