using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookCatalog.Domain;

namespace BookCatalog.DAL
{
    public class DbInitializer : DropCreateDatabaseAlways<BookCatalogContext>
    {
        protected override void Seed(BookCatalogContext context)
        {
        }
    }
}
