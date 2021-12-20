using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HenryPractice2.Models
{
    public partial class cottrell2021Context : DbContext
    {
        public cottrell2021Context()
        {
        }

        public cottrell2021Context(DbContextOptions<cottrell2021Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookandcost> Bookandcosts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bookandcost>(entity =>
            {
                entity.HasKey(e => e.Bookcode)
                    .HasName("PK__bookandc__8913FFF9783D8542");

                entity.ToTable("bookandcost");

                entity.Property(e => e.Bookcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("bookcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("title")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.HasSequence<int>("globalCounter")
                .StartsAt(10)
                .IncrementsBy(5);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
