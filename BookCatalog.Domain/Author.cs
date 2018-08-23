using System;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalog.Domain
{
    public class Author
    {
        public Guid AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int BookCount => Books.Count();

        public virtual ICollection<Book> Books { get; set; }
    }
}
