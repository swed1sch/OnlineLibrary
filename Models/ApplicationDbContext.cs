using Microsoft.EntityFrameworkCore;

namespace OnlineLibrary.Models
{
    public class ApplicationDbContext : DbContext
    {        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
