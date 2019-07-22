using System.Data.Entity;
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
