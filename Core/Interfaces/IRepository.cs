using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<T>
    {
        public void Create(T value);
        public void UpdateById(Guid id);
        public void DeleteById(Guid id);
        public void DeleteAll();
        public List<T> GetById(Guid id);
        public List<T> GetByName(string name);
        public List<T> GetAll();
    }
}
