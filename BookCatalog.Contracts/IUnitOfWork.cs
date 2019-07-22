using BookCatalog.Domain;

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
