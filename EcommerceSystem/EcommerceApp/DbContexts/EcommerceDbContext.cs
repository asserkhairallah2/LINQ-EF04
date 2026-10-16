#region Namespaces
using Microsoft.EntityFrameworkCore;
using EcommerceApp.Models;
#endregion

namespace EcommerceApp.DbContexts
{
    #region EcommerceDbContext Class
    public class EcommerceDbContext : DbContext
    {
        #region DbSets
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        #endregion

        #region OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EcommerceDb;User Id=yermux;Password=.Mode@0987@.;TrustServerCertificate=True;");
        }
        #endregion

        #region OnModelCreating (Fluent API Configurations)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Composite Primary Key for OrderDetail
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.ProductId });
            #endregion

            #region Relationships & Delete Behaviors
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
        #endregion
    }
    #endregion
}