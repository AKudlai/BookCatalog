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
            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "You Don't Know JS: ES6 & Beyond ",
                PageCount = 278,
                Rating = 5,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Kyle",
                        LastName = "Simpson"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "High Performance JavaScript",
                PageCount = 242,
                Rating = 4,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Nicholas C.",
                        LastName = "Zakas"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "JavaScript Patterns",
                PageCount = 216,
                Rating = 4,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Stoyan",
                        LastName = "Stefanov"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "Domain-Driven Design: Tackling Complexity in the Heart of Software",
                PageCount = 448,
                Rating = 5,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Eric",
                        LastName = "Evans"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "Grokking Algorithms An Illustrated Guide For Programmers and Other Curious People",
                PageCount = 288,
                Rating = 5,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Aditya Y.",
                        LastName = "Bhargava"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "CLR via C#",
                PageCount = 896,
                Rating = 5,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Jeffrey",
                        LastName = "Richter"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "Waltzing with Bears: Managing Risk on Software Projects",
                PageCount = 196,
                Rating = 4,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Tom",
                        LastName = "DeMarco"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "Rework",
                PageCount = 208,
                Rating = 4,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Jason",
                        LastName = "Fried"
                    },
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "David Heinemeier",
                        LastName = "Hansson"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "Antifragile: Things That Gain from Disorder",
                PageCount = 768,
                Rating = 4,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Nassim Nicholas",
                        LastName = "Taleb"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "Pro Git",
                PageCount = 574,
                Rating = 4,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Scott",
                        LastName = "Chacon"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "Algorithm Design",
                PageCount = 800,
                Rating = 5,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Jon",
                        LastName = "Kleinberg"
                    },
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Éva",
                        LastName = "Tardos"
                    }
                }
            });

            context.Books.Add(new Book
            {
                BookId = Guid.NewGuid(),
                Name = "Design Patterns via C#",
                PageCount = 288,
                Rating = 5,
                Authors = new List<Author>
                {
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Aleksandr",
                        LastName = "Shevchuk"
                    },
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Dmitriy",
                        LastName = "Okhrimenko"
                    },
                    new Author
                    {
                        AuthorId = Guid.NewGuid(),
                        FirstName = "Andrey",
                        LastName = "Kas'yanov"
                    }
                }
            });

            base.Seed(context);
        }
    }
}
