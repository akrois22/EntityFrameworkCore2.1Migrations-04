﻿// <auto-generated />
using Festify.WebRepository.Explore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Festify.WebRepository.Migrations.Explore
{
    [DbContext(typeof(ExploreContext))]
    [Migration("20190919165402_AddedConferenceAndSpeaker")]
    partial class AddedConferenceAndSpeaker
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Festify.Domain.Explore.Conference", b =>
                {
                    b.Property<int>("ConferenceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Identity")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ConferenceId");

                    b.HasAlternateKey("Identity");

                    b.ToTable("Conference");
                });

            modelBuilder.Entity("Festify.Domain.Explore.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
