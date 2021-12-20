using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HenryBooksEF.Models
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

        public virtual DbSet<Alsorder> Alsorders { get; set; }
        public virtual DbSet<AlsorderDetailsTable> AlsorderDetailsTables { get; set; }
        public virtual DbSet<Amrorder> Amrorders { get; set; }
        public virtual DbSet<AmrorderDetailsTable> AmrorderDetailsTables { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Copy> Copies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Eforder> Eforders { get; set; }
        public virtual DbSet<EforderDetail> EforderDetails { get; set; }
        public virtual DbSet<Khmorder> Khmorders { get; set; }
        public virtual DbSet<KhmorderDetailsTable> KhmorderDetailsTables { get; set; }
        public virtual DbSet<Lhmorder> Lhmorders { get; set; }
        public virtual DbSet<LhmorderDetailsTable> LhmorderDetailsTables { get; set; }
        public virtual DbSet<Ljgorder> Ljgorders { get; set; }
        public virtual DbSet<LjgorderDetailsTable> LjgorderDetailsTables { get; set; }
        public virtual DbSet<Lmcorder> Lmcorders { get; set; }
        public virtual DbSet<LmcorderDetailsTable> LmcorderDetailsTables { get; set; }
        public virtual DbSet<MldorderDetailsTable> MldorderDetailsTables { get; set; }
        public virtual DbSet<MldorderTable> MldorderTables { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Slkorder> Slkorders { get; set; }
        public virtual DbSet<SlkorderDetailsTable> SlkorderDetailsTables { get; set; }
        public virtual DbSet<Wlgorder> Wlgorders { get; set; }
        public virtual DbSet<WlgorderDetail> WlgorderDetails { get; set; }
        public virtual DbSet<Wrote> Wrotes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Alsorder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("ALSOrders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<AlsorderDetailsTable>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("ALSOrderDetailsTable");

                entity.HasIndex(e => e.OrderId, "IX_ALSOrderDetailsTable_OrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PropId).HasColumnName("PropID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.AlsorderDetailsTables)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Amrorder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("AMROrders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<AmrorderDetailsTable>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("AMROrderDetailsTable");

                entity.HasIndex(e => e.OrderId, "IX_AMROrderDetailsTable_OrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PropId).HasColumnName("PropID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.AmrorderDetailsTables)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.AuthorNum)
                    .HasName("PK__Author__7E6BD29CED3B4E43");

                entity.ToTable("Author");

                entity.Property(e => e.AuthorNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.AuthorFirst)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AuthorLast)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookCode)
                    .HasName("PK__Book__0A5FFCC675264B31");

                entity.ToTable("Book");

                entity.Property(e => e.BookCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Paperback)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PublisherCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Title)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.PublisherCodeNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublisherCode)
                    .HasConstraintName("FK_Book_Publisher1");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BranchNum)
                    .HasName("PK__Branch__0E8D21C5E309471C");

                entity.ToTable("Branch");

                entity.Property(e => e.BranchNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.BranchLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Copy>(entity =>
            {
                entity.HasKey(e => new { e.BookCode, e.BranchNum, e.CopyNum })
                    .HasName("PK__Copy__3462780CD9589406");

                entity.ToTable("Copy");

                entity.Property(e => e.BookCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CopyNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Quality)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.BookCodeNavigation)
                    .WithMany(p => p.Copies)
                    .HasForeignKey(d => d.BookCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Copy_Book");

                entity.HasOne(d => d.BranchNumNavigation)
                    .WithMany(p => p.Copies)
                    .HasForeignKey(d => d.BranchNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Copy_Branch");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__customer__9725F2E66CEF958C");

                entity.ToTable("customer");

                entity.Property(e => e.CustId).HasColumnName("custID");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fname");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lname");

                entity.Property(e => e.PayDetails)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("payDetails");
            });

            modelBuilder.Entity<Eforder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("EFOrders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<EforderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("EFOrderDetails");

                entity.HasIndex(e => e.OrderId, "IX_EFOrderDetails_OrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.EforderDetails)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Khmorder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("KHMOrders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<KhmorderDetailsTable>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("KHMOrderDetailsTable");

                entity.HasIndex(e => e.OrderId, "IX_KHMOrderDetailsTable_OrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PropId).HasColumnName("PropID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.KhmorderDetailsTables)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Lhmorder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("LHMOrders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<LhmorderDetailsTable>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("LHMOrderDetailsTable");

                entity.HasIndex(e => e.OrderId, "IX_LHMOrderDetailsTable_OrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PropId).HasColumnName("PropID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LhmorderDetailsTables)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Ljgorder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("LJGOrders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<LjgorderDetailsTable>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("LJGOrderDetailsTable");

                entity.HasIndex(e => e.OrderId, "IX_LJGOrderDetailsTable_orderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.PropId).HasColumnName("propID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LjgorderDetailsTables)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Lmcorder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("LMCOrders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            });

            modelBuilder.Entity<LmcorderDetailsTable>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("LMCOrderDetailsTable");

                entity.HasIndex(e => e.OrderId, "IX_LMCOrderDetailsTable_OrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LmcorderDetailsTables)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<MldorderDetailsTable>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("MLDOrderDetailsTable");

                entity.HasIndex(e => e.OrderId, "IX_MLDOrderDetailsTable_OrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PropId).HasColumnName("PropID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.MldorderDetailsTables)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<MldorderTable>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("MLDOrderTable");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.PublisherCode)
                    .HasName("PK__Publishe__DFB88E28038BEC4C");

                entity.ToTable("Publisher");

                entity.Property(e => e.PublisherCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PublisherName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.ResNum)
                    .HasName("PK__reservat__2993031695141F1D");

                entity.ToTable("reservation");

                entity.Property(e => e.ResNum).HasColumnName("resNum");

                entity.Property(e => e.DateIn)
                    .HasColumnType("date")
                    .HasColumnName("dateIn");

                entity.Property(e => e.DateOut)
                    .HasColumnType("date")
                    .HasColumnName("dateOut");

                entity.Property(e => e.GuestId).HasColumnName("guestID");

                entity.Property(e => e.RoomNum).HasColumnName("roomNum");

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.GuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reservati__guest__797309D9");
            });

            modelBuilder.Entity<Slkorder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("SLKOrders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<SlkorderDetailsTable>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("SLKOrderDetailsTable");

                entity.HasIndex(e => e.OrderId, "IX_SLKOrderDetailsTable_OrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PropId).HasColumnName("PropID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.SlkorderDetailsTables)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Wlgorder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("WLGOrders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            });

            modelBuilder.Entity<WlgorderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("WLGOrderDetail");

                entity.HasIndex(e => e.OrderId, "IX_WLGOrderDetail_OrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PropId).HasColumnName("PropID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.WlgorderDetails)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Wrote>(entity =>
            {
                entity.HasKey(e => new { e.BookCode, e.AuthorNum })
                    .HasName("PK__Wrote__DDB941EF2F21FE91");

                entity.ToTable("Wrote");

                entity.Property(e => e.BookCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AuthorNum).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Sequence).HasColumnType("decimal(2, 0)");

                entity.HasOne(d => d.AuthorNumNavigation)
                    .WithMany(p => p.Wrotes)
                    .HasForeignKey(d => d.AuthorNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wrote_Author");

                entity.HasOne(d => d.BookCodeNavigation)
                    .WithMany(p => p.Wrotes)
                    .HasForeignKey(d => d.BookCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wrote_Book");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
