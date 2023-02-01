using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Loan
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }

        public Loan(Book book, User user) { 
            Id = new Guid();
            this.Book = book;
            this.User = user;
            this.StartDate = new DateTime();
        }
    }
}
