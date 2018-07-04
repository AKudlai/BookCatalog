using BookCatalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Contracts
{
    public interface IUnitOfWork
    {
        IGenericRepository<Book> Books { get; }

        IGenericRepository<Author> Authors { get; }

        void SaveChanges();

        void Dispose();
    }
}
