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
        private readonly IRepository<User> _userRepo;
        private readonly IRepository<Loan> _loanRepo;
        private readonly IRepository<Book> _bookRepo;

        public MainBusinessLogic(IRepository<User> userRepo, IRepository<Loan> loanRepo, IRepository<Book> bookRepo)
        {
            _userRepo = userRepo;
            _loanRepo = loanRepo;
            _bookRepo = bookRepo;
        }

        public string CreateBook(string title, string author)
        {
            try
            { 
                _bookRepo.Create(new Book(title, author));
                return "Book added";
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }

        public void DeleteBookList(Guid id)
        {
            _bookRepo.DeleteById(id);
        }

        public void DeleteBookById()
        {
            _bookRepo.DeleteAll();
        }

        public string DeleteBook(Guid id)
        {
            try
            {
                _bookRepo.DeleteById(id);
                return $"Deleted book";
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepo.GetAll();
        }

        public string CreateUser(string name)
        {
            try
            {
                string firstName = name.Split(" ")[0];
                string lastName = name.Split(" ")[1];
                _userRepo.Create(new User(firstName, lastName));
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
                _userRepo.DeleteById(id);
                return $"Deleted user";
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }

        public List<User> GetAllUsers()
        {
            return _userRepo.GetAll();
        }

        public void LoanBook(Book book, User user)
        {
            if (_bookRepo.CheckBookAvailability(book.Title))
                _loanRepo.Create(new Loan(book, user));
            else
                throw new ArgumentException($"{book.Title} is already loaned");
        }

        public void ReturnBook(Book book, User user)
        {
            throw new NotImplementedException();
        }

        List<Loan> GetLoansByUser(User user)
        {
            if (user != null)
                throw new ArgumentException("Invalid User");
            var loan = _loanRepo.GetLoanByUser(user);
            return null;
        }

        List<Loan> GetLoansByBook(Book book)
        {
            if (book != null)
                throw new ArgumentException("Invalid Name Book");
            var loan = _loanRepo.GetLoanByBook(name);
            return null;
        }

        public List<Loan> GetLoansById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Loan> GetAllLoans()
        {
            throw new NotImplementedException();
        }

        public string CreateBook(string title)
        {
            throw new NotImplementedException();
        }

        List<Loan> IMainBusinessLogic.GetLoansByUser(User user)
        {
            throw new NotImplementedException();
        }

        List<Loan> IMainBusinessLogic.GetLoansByBook(Book book)
        {
            throw new NotImplementedException();
        }
    } 
}
