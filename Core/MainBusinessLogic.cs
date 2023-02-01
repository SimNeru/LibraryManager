using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MainBusinessLogic : IMainBusinessLogic
    {
        private readonly IRepository<Loan> _loanRepo;
        private readonly IRepository<User> _userRepo;
        private readonly IRepository<Book> _bookRepo;

        public MainBusinessLogic(IRepository<Loan> loanRepo)
        {
            _loanRepo = loanRepo;
        }

        public Loan GetLoansByBook(string name)
        {
            if (name.Equals("") && name.Equals(string.Empty))
                throw new ArgumentException("Invalid Name Book");
            try {
                var loan = _loanRepo.GetLoanByBook(name);
            }catch(Exception){
                return null;
            }
        }

        public Loan GetLoansByUser(string name, string lastname)
        {
            if (name.Equals("") && name.Equals(string.Empty))
                throw new ArgumentException("Invalid Name Book");
            try
            {
                var loan = _loanRepo.GetLoanByUser(name,lastname);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void LoanBook(Book book, User user)
        {
            if (_bookRepo.CheckBookAvailability(book.Title))
                _loanRepo.Create(new Loan(book, user));
            else
                throw new ArgumentException($"{book.Title} is already loaned");
        }



        public void CreateBook()
        {
            throw new NotImplementedException();
        }

        public void CreateUser()
        {
            throw new NotImplementedException();
        }

        public void DeleteBook()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public void GetBook()
        {
            throw new NotImplementedException();
        }

        public void GetUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateBook()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }

        public void ReturnBook(Book book, User user)
        {
            throw new NotImplementedException();
        }

        public List<Loan> GetLoansById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Loan> GetAllLoans()
        {
            throw new NotImplementedException();
        }
    }
}
