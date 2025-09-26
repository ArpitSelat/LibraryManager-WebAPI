using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed some initial data
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Clean Code",
                    Author = "Robert C. Martin",
                    ISBN = "978-0132350884",
                    PublicationYear = 2008,
                    Publisher = "Prentice Hall",
                    Quantity = 5,
                    IsAvailable = true
                },
                new Book
                {
                    Id = 2,
                    Title = "Design Patterns",
                    Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                    ISBN = "978-0201633610",
                    PublicationYear = 1994,
                    Publisher = "Addison-Wesley Professional",
                    Quantity = 3,
                    IsAvailable = true
                },
                new Book
                {
                    Id = 3,
                    Title = "The Pragmatic Programmer",
                    Author = "Andrew Hunt, David Thomas",
                    ISBN = "978-0201616224",
                    PublicationYear = 1999,
                    Publisher = "Addison-Wesley Professional",
                    Quantity = 2,
                    IsAvailable = true
                }
            );
        }
    }
}
