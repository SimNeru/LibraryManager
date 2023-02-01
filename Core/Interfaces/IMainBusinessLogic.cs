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
        public void LoanBook(Book book, User user);
        public void ReturnBook(Book book, User user);
        public List<Loan> GetLoansByUser(string name, string lastname);
        public List<Loan> GetLoansByBook(string name);
        public List<Loan> GetLoansById(Guid id);
        public List<Loan> GetAllLoans();
    }
}
