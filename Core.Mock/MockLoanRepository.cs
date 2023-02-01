using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mock
{
    public class MockLoanRepository : IRepository<Loan>
    {
        List<Loan> bookLoaned;
        public MockLoanRepository() {
            bookLoaned = new List<Loan>() { 
            new Loan(new Book("Harry Potter","Rowling"), new User("1","2")),
            new Loan(new Book("a","b"), new User("3","4")),
            new Loan(new Book("c","d"), new User("5","6")),
            new Loan(new Book("e","f"), new User("7","8")),
            new Loan(new Book("g","h"), new User("9","10")),
            new Loan(new Book("i","l"), new User("11","12")),
            new Loan(new Book("m","n"), new User("13","14")),
            new Loan(new Book("o","p"), new User("15","16")),
            new Loan(new Book("q","r"), new User("17","18")),
            };
        }
        public void Create(Loan loan)
        {
            bookLoaned.Add(loan);
        }

        public void DeleteAll()
        {
            bookLoaned.Clear();
        }

        public void DeleteById(Guid id)
        {
            foreach (var loan in bookLoaned) {
                if (loan.Id == id)
                    bookLoaned.Remove(loan);
            }
        }

        public Loan GetById(Guid id)
        {
            foreach (var loan in bookLoaned)
            {
                if(loan.Id==id)
                    return loan;
            }
            return null;
        }

        public Loan GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(Guid id)
        {
            foreach (var loan in bookLoaned)
            {
                if (loan.Id == id)
                {
                    loan.Book.Return();
                    loan.EndDate = new DateTime();
                }
            }
        }
    }
}
