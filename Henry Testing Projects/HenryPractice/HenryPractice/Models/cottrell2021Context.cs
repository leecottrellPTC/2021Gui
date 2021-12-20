using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HenryPractice.Models
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

        public virtual DbSet<Bookcost> Bookcosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:cottrellsql.database.windows.net,1433;Initial Catalog=cottrell2021;Persist Security Info=False;User ID=fiction;Password=a,plain3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bookcost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("bookcosts");

                entity.Property(e => e.Bookcode)
                    .IsRequired()
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
