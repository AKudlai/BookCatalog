using BookCatalog.Contracts;
using BookCatalog.Domain;
using System;
using System.Data.Entity;
using BookCatalog.DAL;

namespace BookCatalog.Services.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext context;

        private IGenericRepository<Book> booksRepository;

        private IGenericRepository<Author> authorsRepository;

        private bool disposed = false;

        public UnitOfWork()
        {
            this.context = new BookCatalogContext();
        }

        public IGenericRepository<Book> Books => this.booksRepository ?? (this.booksRepository = new GenericRepository<Book>(this.context));

        public IGenericRepository<Author> Authors => this.authorsRepository ?? (this.authorsRepository = new GenericRepository<Author>(this.context));

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
