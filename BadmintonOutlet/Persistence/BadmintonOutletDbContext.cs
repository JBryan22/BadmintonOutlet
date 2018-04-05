using BadmintonOutlet.Models;
using Microsoft.EntityFrameworkCore;

namespace BadmintonOutlet.Persistence
{
    public class BadmintonOutletDbContext : DbContext
    {
        public BadmintonOutletDbContext(DbContextOptions<BadmintonOutletDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RacquetSeries> RacquetSeries { get; set; }
    }
}