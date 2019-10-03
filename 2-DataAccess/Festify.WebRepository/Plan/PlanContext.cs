using Festify.Domain.Plan;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Festify.WebRepository.Plan
{
    public class PlanContext : DbContext
    {
        public PlanContext(DbContextOptions<PlanContext> options) : base(options)
        {
        }
        public DbSet<Presenter> Presenter { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Submission>()
                .HasIndex(x => x.ConferenceId);

            modelBuilder.Entity<Submission>()
                .Property(x => x.DateSubmitted)
                .HasColumnType("DATETIME2");

            modelBuilder.Entity<Submission>()
                .Property(x => x.DateAccepted)
                .HasColumnType("DATETIME2");
        }
    }
}
