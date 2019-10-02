using Festify.Domain.Explore;
using Festify.Domain.Plan;
using Microsoft.EntityFrameworkCore;

namespace Festify.WebRepository.Explore
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

            //modelBuilder.Entity<Session>()
            //    .HasKey(x => x.SessionId);

            //modelBuilder.Entity<Speaker>()
            //    .HasKey(x => x.SpeakerId);

            //modelBuilder.Entity<Presenter>()
            //    .HasKey(x => x.PresenterId);

            //modelBuilder.Entity<Submission>()
            //    .HasKey(x => x.SubmissionId);

            //modelBuilder.Entity<Talk>()
            //    .HasKey(x => x.TalkId);

        }
    }
}
