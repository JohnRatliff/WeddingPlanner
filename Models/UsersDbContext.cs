using Microsoft.EntityFrameworkCore;
 
namespace WeddingPlanner.Models
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options) { }

        public DbSet<User> User { get;set; }

    }
}
