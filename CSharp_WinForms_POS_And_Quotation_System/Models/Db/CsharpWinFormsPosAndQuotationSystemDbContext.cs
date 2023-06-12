using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CSharp_WinForms_POS_And_Quotation_System.Models.Db;

public partial class CsharpWinFormsPosAndQuotationSystemDbContext : DbContext
{
    public CsharpWinFormsPosAndQuotationSystemDbContext()
    {
    }

    public CsharpWinFormsPosAndQuotationSystemDbContext(DbContextOptions<CsharpWinFormsPosAndQuotationSystemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SaleDetail> SaleDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Server=localhost;Database=Learn_CSharp_EFCore_Beginner_DB;User ID=sa;Password=root;TrustServerCertificate=true;");

        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Barcode }).HasName("PK_Products");

            entity.ToTable("Product");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Barcode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CostPrice).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SellingPrice).HasColumnType("money");
            entity.Property(e => e.UnitName).HasMaxLength(20);

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Product_Category");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.ToTable("Product_Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.ReceiptId).HasName("PK_Sale_1");

            entity.ToTable("Sale");

            entity.Property(e => e.ReceiptId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ReceiptID");
            entity.Property(e => e.ChangeMoney).HasColumnType("money");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReceiveMoney).HasColumnType("money");
            entity.Property(e => e.Total).HasColumnType("money");
        });

        modelBuilder.Entity<SaleDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sale_Detail");

            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.ProductPrice).HasColumnType("money");
            entity.Property(e => e.ReceiptId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ReceiptID");
            entity.Property(e => e.SubTotal).HasColumnType("money");

            entity.HasOne(d => d.Receipt).WithMany()
                .HasForeignKey(d => d.ReceiptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sale_Detail_Sale");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
