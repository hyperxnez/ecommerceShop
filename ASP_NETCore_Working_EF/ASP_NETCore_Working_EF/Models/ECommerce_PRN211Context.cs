using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace ASP_NETCore_Working_EF.Models
{
    public partial class ECommerce_PRN211Context : DbContext
    {
        public ECommerce_PRN211Context()
        {
        }

        public ECommerce_PRN211Context(DbContextOptions<ECommerce_PRN211Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CheckoutInfo> CheckoutInfos { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot config = builder.Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("MyDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.OId)
                    .HasName("PK__Bill__C2FECB1B4297CAEB");

                entity.ToTable("Bill");

                entity.Property(e => e.OId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("oID");

                entity.Property(e => e.CAddress)
                    .HasMaxLength(100)
                    .HasColumnName("cAddress");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Cname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("cname");

                entity.Property(e => e.Cphone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cphone");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasColumnName("total");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("FK__Bill__cid__48CFD27E");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasKey(e => new { e.Pid, e.OId })
                    .HasName("PK__BillDeta__711835AB42AA4D3B");

                entity.ToTable("BillDetail");

                entity.Property(e => e.Pid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pid");

                entity.Property(e => e.OId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("oID");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasColumnName("total");

                entity.HasOne(d => d.OIdNavigation)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.OId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillDetail__oID__49C3F6B7");

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillDetail__pid__4AB81AF0");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CateId)
                    .HasName("PK__Category__A88B4DC4E4C0B70C");

                entity.ToTable("Category");

                entity.Property(e => e.CateId).HasColumnName("cateID");

                entity.Property(e => e.CateName)
                    .HasMaxLength(50)
                    .HasColumnName("cateName");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CheckoutInfo>(entity =>
            {
                entity.ToTable("checkout_info");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .HasColumnName("company_name");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Town)
                    .HasMaxLength(50)
                    .HasColumnName("town");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .HasColumnName("zip_code");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CheckoutInfos)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_checkout_info_country");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Customer__D837D05F2EC6310B");

                entity.ToTable("Customer");

                entity.HasIndex(e => e.Username, "UQ__Customer__F3DBC572454D9FCA")
                    .IsUnique();

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.CAddress)
                    .HasMaxLength(100)
                    .HasColumnName("cAddress");

                entity.Property(e => e.Cname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("cname");

                entity.Property(e => e.Cphone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cphone");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Salt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("salt");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckoutInfoId).HasColumnName("checkout_info_id");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasColumnName("total");

                entity.HasOne(d => d.CheckoutInfo)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CheckoutInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_order_checkout_info");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("order_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_order_item_order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_order_item_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__DD37D91A31724075");

                entity.ToTable("Product");

                entity.Property(e => e.Pid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pid");

                entity.Property(e => e.CateId).HasColumnName("cateID");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("pname");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Cate)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CateId)
                    .HasConstraintName("FK__Product__cateID__47DBAE45");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
