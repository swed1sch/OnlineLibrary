using System.Linq;
namespace OnlineLibrary.Models
{
    public class EFUserRepository
    {
        private ApplicationDbContext context;

        public EFUserRepository(ApplicationDbContext ctx) => context = ctx;
       
        public IQueryable<User> Users => context.Users;

    }
}
