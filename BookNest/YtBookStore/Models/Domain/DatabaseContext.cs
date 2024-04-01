using Microsoft.EntityFrameworkCore;

namespace YtBookStore.Models.Domain
{
    // Database context class for managing database operations
    public class DatabaseContext : DbContext
    {
        // Constructor with DbContextOptions parameter
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        // DbSet for Genre entity
        public DbSet<Genre> Genre { get; set; }

        // DbSet for Author entity
        public DbSet<Author> Author { get; set; }

        // DbSet for Publisher entity
        public DbSet<Publisher> Publisher { get; set; }

        // DbSet for Book entity
        public DbSet<Book> Book { get; set; }
    }
}
