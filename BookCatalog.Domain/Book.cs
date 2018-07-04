using System;
using System.Collections.Generic;

namespace BookCatalog.Domain
{
    public class Book
    {
        public Guid BookId { get; set; }

        public string Name { get; set; }

        public int PageCount { get; set; }

        public int Rating { get; set; }

        public ICollection<Author> Authors { get; set; }

        public Book()
        {
            Authors = new List<Author>();
        }
    }
}
