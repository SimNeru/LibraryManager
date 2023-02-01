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
        public void CreateUser();

        public void GetUser();

        public void UpdateUser();

        public void DeleteUser();

        public void GetAllUsers();

        public void CreateBook();

        public void GetBook();

        public void UpdateBook();

        public void DeleteBook();

    }
}
