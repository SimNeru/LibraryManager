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

        public Book(Guid id, string title, string author, bool availability)
        {
            Id = id;
            Title = title;
            Author = author;
            Availability = availability;
        }

        public override string ToString()
        {
            return $"[Id]:{Id}\n[Title]:{Title}\n[Author]:{Author}\n[Availability]:{Availability}\n";
        }
    }
}
