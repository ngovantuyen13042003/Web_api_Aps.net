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
        public DbSet<Images> images { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Book_Category> book_Categories { get; set; }
        public DbSet<Book_Images> book_Images { get; set; }
        public DbSet<Customer_Book> customer_Books { get; set; }
        public DbSet<Cart_Book> cart_Books { get; set; }
        public DbSet<Account_Role> account_Roles { get; set; }
        public DbSet<Account> account { get; set; }
        public DbSet<Role> role { get; set; }
        public DbSet<Employee> employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Category
            modelBuilder.Entity<Category>()
                .ToTable("category")
                .HasKey(c => c.id);

            // Book
            modelBuilder.Entity<Book>()
                .ToTable("book")
                .HasKey(b => b.id);

            // Book_Category
            modelBuilder.Entity<Book_Category>(entity =>
            {
                entity.ToTable("book_category")
                    .HasKey(bc => new { bc.bookId, bc.categoryId });

                entity.HasOne(bc => bc.book)
                   .WithMany(bc => bc.book_Categories)
                   .HasForeignKey(bc => bc.bookId);

                entity.HasOne(bc => bc.category)
                   .WithMany(bc => bc.book_Categories)
                   .HasForeignKey(bc => bc.categoryId);
            });

            // Images
            modelBuilder.Entity<Images>()
                .ToTable("images")
                .HasKey(i => i.Id);

            // Book_Images
            modelBuilder.Entity<Book_Images>()
                .ToTable("book_images")
                .HasKey(bi => new { bi.imageId, bi.bookId });
            modelBuilder.Entity<Book_Images>()
                .HasOne(bi => bi.image)
                .WithMany(bi => bi.book_Images)
                .HasForeignKey(bi=>bi.imageId);
            modelBuilder.Entity<Book_Images>()
                .HasOne(bi=> bi.book)
                .WithMany(bi => bi.book_Images)
                .HasForeignKey(bi => bi.bookId);

            // Customer
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");
                entity.HasKey(c => c.Id);
            });

            //customer_book
            modelBuilder.Entity<Customer_Book>()
                .ToTable("customer_book")
                .HasKey(cb => new { cb.bookId, cb.customerId });
            modelBuilder.Entity<Customer_Book>()
                .HasOne(b => b.book)
                .WithMany(bc => bc.customer_Books)
                .HasForeignKey(i => i.bookId);
            modelBuilder.Entity<Customer_Book>()
               .HasOne(b => b.customer)
               .WithMany(bc => bc.customer_Books)
               .HasForeignKey(c => c.customerId);

            // cart 
            modelBuilder.Entity<Cart>()
            .HasKey(c => c.IdCart);

            // Cart_Book
            modelBuilder.Entity<Cart_Book>(entity =>
            {
                entity.ToTable("cart_book");
                entity.HasKey(cb => new { cb.bookId, cb.cartId });

                entity.HasOne(cb => cb.book)
                     .WithMany(cb => cb.cart_Books)
                     .HasForeignKey(cb => cb.bookId);

                entity.HasOne(cb => cb.cart)
                     .WithMany(cb => cb.cart_Books)
                     .HasForeignKey(cb => cb.cartId);
            });

            // Role
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");
                entity.HasKey(r => r.id);
            });

            // Employee
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");
                entity.HasKey(e => e.id);
            });

            // Account
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");
                entity.HasKey(a =>new { a.id});

                entity.HasOne(a => a.employee)
                     .WithMany(a => a.account)
                     .HasForeignKey(a => a.employeeId);
                entity.HasOne(a => a.customer)
                    .WithMany(a => a.accounts)
                    .HasForeignKey(a => a.customerId);
            });

            // Account_Role

            modelBuilder.Entity<Account_Role>(entity =>
            {
                entity.ToTable("account_role");
                entity.HasKey(ar => new { ar.roleId, ar.accountId });

                entity.HasOne(ar => ar.account)
                    .WithMany(ar => ar.account_Roles)
                    .HasForeignKey(ar => ar.accountId);

                entity.HasOne(ar => ar.role)
                    .WithMany(ar => ar.account_Roles)
                    .HasForeignKey(ar => ar.roleId);
            });








        }
    }
}
