﻿// <auto-generated />
using Festify.MobileRepository.Explore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Festify.MobileRepository.Migrations
{
    [DbContext(typeof(ExploreContext))]
    partial class ExploreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Festify.Domain.Explore.Conference", b =>
                {
                    b.Property<int>("ConferenceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Identity")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ConferenceId");

                    b.HasAlternateKey("Identity");

                    b.ToTable("Conference");
                });

            modelBuilder.Entity("Festify.Domain.Explore.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abstract")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("SessionId");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("Festify.Domain.Explore.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ConferenceId");

                    b.HasKey("SpeakerId");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("Festify.Domain.Explore.Speaker", b =>
                {
                    b.HasOne("Festify.Domain.Explore.Conference", "Conference")
                        .WithMany("Speakers")
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
