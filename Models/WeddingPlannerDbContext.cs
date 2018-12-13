using Microsoft.EntityFrameworkCore;
 
namespace WeddingPlanner.Models
{
    public class WeddingPlannerDbContext : DbContext
    {
        public WeddingPlannerDbContext(DbContextOptions<WeddingPlannerDbContext> options) : base(options) { }

        public DbSet<WeddingView> WeddingView { get;set; }
        public DbSet<Wedding> Wedding { get;set; }
        public DbSet<User> User { get;set; }
        public DbSet<Guest> Guest { get;set; }

    }
}
