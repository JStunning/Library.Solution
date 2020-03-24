using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : DbContext
  {
    public virtual DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BookAuthor> BookAuthor { get; set; }

    public DbSet<Patron> Patrons { get; set; }
    public DbSet<Copy> Copys { get; set; }
    public DbSet<Checkout> Checkout { get; set; }

    public LibraryContext(DbContextOptions options) : base(options) { }
  }
}