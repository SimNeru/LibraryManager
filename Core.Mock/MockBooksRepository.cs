﻿using Core.Entities;
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

        List<Book> books;

        public MockBooksRepository()
        {
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