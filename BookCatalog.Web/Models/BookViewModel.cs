using BookCatalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookCatalog.Web.Models
{
    public class BookViewModel
    {
        public Guid BookId { get; set; }

        public string Name { get; set; }

        public int PublishDate { get; set; }

        public int PageCount { get; set; }

        public int Rating { get; set; }

        public IEnumerable<AuthorViewModel> Authors { get; set; }
    }
}