using Books_APIweb.Model;
using Microsoft.EntityFrameworkCore;

namespace Books_APIweb.Context
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) 
        {
        }

        public DbSet<Book>? Books { get; set; }
    }
}
