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
        public void LoanBook(Book book, User user);
        public void ReturnBook(Book book, User user);
        public List<Loan> GetLoansByUser(User user);
        public List<Loan> GetLoansByBook(Book book);
        public List<Loan> GetLoansById(Guid id);
        public List<Loan> GetAllLoans();
    }
}
