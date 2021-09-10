using Microsoft.EntityFrameworkCore;
using BooManagerApi;

namespace BooManagerApi.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> BookItems { get; set; }
    }
}