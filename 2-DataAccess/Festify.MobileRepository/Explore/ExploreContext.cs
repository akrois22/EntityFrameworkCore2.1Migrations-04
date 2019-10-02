using Festify.Domain.Explore;
using Microsoft.EntityFrameworkCore;

namespace Festify.MobileRepository.Explore
{
    public class ExploreContext : DbContext
    {
        public ExploreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Conference> Conference { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conference>()
                .HasAlternateKey(x => x.Identity);

            modelBuilder.Entity<Session>()
                .HasKey(x => x.SessionId);
        }
    }
}
