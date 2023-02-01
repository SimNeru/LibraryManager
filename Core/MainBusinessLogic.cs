using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core
{
    public class MainBusinessLogic : IMainBusinessLogic
    {
        public IRepository<User> userRepo;


        public MainBusinessLogic(IRepository<User> userRepo ) { 
            this.userRepo = userRepo;
        }

        public string CreateBook(string title)
        {
            throw new NotImplementedException();
        }

        public string DeleteBook(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public string CreateUser(string name)
        {
            try
            {
                string firstName = name.Split(" ")[0];
                string lastName = name.Split(" ")[1];
                userRepo.Create(new User(firstName, lastName));
                return $"Created user {firstName} {lastName}";
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }

        public string DeleteUser(Guid id)
        {
            try
            {
                userRepo.DeleteById(id);
                return $"Deleted user";
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }

        public List<User> GetAllUsers()
        {
            return userRepo.GetAll();
        }
    }
}
