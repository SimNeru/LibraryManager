using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IMainBusinessLogic
    {
        public string CreateBook(string title);
        public string DeleteBook(Guid id);
        public List<Book> GetAllBooks();
        public string CreateUser(string name);
        public string DeleteUser(Guid id);
        public List<User> GetAllUsers();
    }
}
