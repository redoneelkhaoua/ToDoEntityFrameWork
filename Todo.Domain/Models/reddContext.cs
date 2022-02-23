using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Todo.Domain.Models
{
    public partial class reddContext : DbContext
    {
        public reddContext()
        {
        }

        public reddContext(DbContextOptions<reddContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_United States.1252");

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .HasColumnName("id");

                entity.Property(e => e.Details)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Statue)
                    .HasMaxLength(20)
                    .HasColumnName("statue")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
