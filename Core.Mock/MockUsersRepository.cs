using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mock
{
    public class MockUsersRepository : IRepository<User>
    {
        public List<User> users;

        public MockUsersRepository()
        {
            users = new List<User> {
                new User ("Paolo", "Rossi"),
                new User ("Simone", "Nerucci"),
                new User ("Viorel", "Nastasa"),
                new User ("Andrea", "Nicastro"),
                new User ("Fabio", "Paruta"),
                new User ("Andrea", "Vacca"),
                new User ("Roberto", "Ajolfi"),
                new User ("Franco", "Domolo"),
                new User ("Marco", "Pantani"),
                new User ("Ash", "Ketchum")
            };
        }

        public void Create(User value)
        {
            if (users.Any(user => user.FirstName == value.FirstName && user.LastName == value.LastName))
                throw new ArgumentException("User already registered");
            users.Add(value);
        }

        public void DeleteAll()
        {
            users = new List<User>();
        }

        public void DeleteById(Guid id)
        {
            User userToDelete = users.FirstOrDefault(user => user.Id == id);
            if (userToDelete == null)
                throw new ArgumentException("No registered user with the specified id");
            users.Remove(userToDelete);
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User GetById(Guid id)
        {
            User user = users.FirstOrDefault(user => user.Id == id);
            if (user == null)
                throw new ArgumentException("No registered user with the specified id");
            return user;
        }

        public User GetByName(string name)
        {
            string firstName = name.Split(" ")[0];
            string lastName = name.Split(" ")[1];
            User user = users.FirstOrDefault(user => user.FirstName == firstName && user.LastName == lastName);
            if (user == null)
                throw new ArgumentException("No registered user with the specified id");
            return user;
        }

        public void UpdateById(Guid id)
        {
            User user = users.FirstOrDefault(user => user.Id == id);
            if (user == null)
                throw new ArgumentException("No registered user with the specified id");
            return user;
        }
    }
}
