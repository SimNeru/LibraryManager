using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public User(string firstName, string lastName) 
        {
            Id = Guid.NewGuid();
            FirstName = firstName; 
            LastName = lastName;
        }
    }
}
