using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using BookCatalog.Domain;

namespace BookCatalog.DAL
{
    public class BookCatalogContext : DbContext
    {
        public BookCatalogContext()
        {
            // Turn of lazy loading and proxy classes
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;

            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}
