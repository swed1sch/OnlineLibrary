using System.Linq;
namespace OnlineLibrary.Models
{
    public class EFBookRepository
    {
        private ApplicationDbContext context;
        public EFBookRepository(ApplicationDbContext ctx) => context = ctx;
        public IQueryable<Book> Books => context.Books;
    }
}
