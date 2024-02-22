using Microsoft.EntityFrameworkCore;

namespace Floorballer
{
    public class FloorballContext : DbContext
    {
        public FloorballContext(DbContextOptions<FloorballContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
