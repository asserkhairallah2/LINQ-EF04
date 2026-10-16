#region Namespaces
using Microsoft.EntityFrameworkCore;
using LibraryApp.Models;
#endregion

namespace LibraryApp.DbContexts
{
    #region LibraryDbContext Class
    public class LibraryDbContext : DbContext
    {
        #region DbSets
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        #endregion

        #region OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=LibraryDb;User Id=yermux;Password=.Mode@0987@.;TrustServerCertificate=True;");
        }
        #endregion

        #region OnModelCreating (Fluent API Configurations)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Composite Primary Key for Loan
            modelBuilder.Entity<Loan>()
                .HasKey(l => new { l.BookId, l.BorrowerId });
            #endregion

            #region Relationships & Delete Behaviors
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Borrower)
                .WithMany(br => br.Loans)
                .HasForeignKey(l => l.BorrowerId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
        #endregion
    }
    #endregion
}