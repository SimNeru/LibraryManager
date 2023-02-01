using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Book
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool Availability { get; private set; }

        public Book(string title, string Author) { 
            Id= Guid.NewGuid();
            this.Title= title;
            this.Author= Author;
            Availability = true;
        }

        public void Return() {
            Availability = true;
        }

        public void Loan()
        {
            Availability = false;
        }

        public override string ToString()
        {
            return $"[Id]:{Id}\n[Title]:{Title}\n[Author]:{Author}\n[Availability]:{Availability}\n";
        }
    }
}
