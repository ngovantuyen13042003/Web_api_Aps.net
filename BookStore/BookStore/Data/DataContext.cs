using BookStore.Model;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Cart> carts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Category
            modelBuilder.Entity<Category>()
                .ToTable("category")
                .HasKey(c => c.id);

            // Book
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book")
                .HasKey(b => b.id);

                entity.HasOne(b => b.category)
                .WithMany(c =>c.books)
                 .HasForeignKey(b => b.categoryId);
            });

            

            // Customer
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");
                entity.HasKey(c => c.Id);
            });


            // cart 
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(c => c.IdCart);
            });

   
        }
    }
}
