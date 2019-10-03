using Festify.Domain.Explore;
using Festify.Domain.Plan;
using Microsoft.EntityFrameworkCore;

namespace Festify.WebRepository.Explore
{
    public class ExploreContext : DbContext
    {
        public ExploreContext(DbContextOptions<ExploreContext> options) : base(options)
        {
        }

        public DbSet<Conference> Conference { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conference>()
                .HasAlternateKey(x => x.Identity);
        }
    }
}
