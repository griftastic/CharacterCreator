using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CharacterCreator.Models;

namespace CharacterCreator.Data
{
    public partial class CharacterCreatorContext : DbContext
    {
        public CharacterCreatorContext()
        {
        }

        public CharacterCreatorContext(DbContextOptions<CharacterCreatorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; } = null!;
        public virtual DbSet<Character> Characters { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ConnectionStrings:CharacterCreator");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>(entity =>
            {
                entity.ToTable("Abilities", "dev");

                entity.Property(e => e.AbilityName).HasMaxLength(20);
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.ToTable("Characters", "dev");

                entity.Property(e => e.Ability).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Teams", "dev");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TeamName).HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Team)
                    .HasForeignKey<Team>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Teams__Id__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
