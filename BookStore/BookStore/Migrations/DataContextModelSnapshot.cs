﻿// <auto-generated />
using System;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Model.Account", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("customerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("employeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("customerId");

                    b.HasIndex("employeeId");

                    b.ToTable("account", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Account_Role", b =>
                {
                    b.Property<Guid>("roleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("roleId", "accountId");

                    b.HasIndex("accountId");

                    b.ToTable("account_role", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Book", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("book", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Book_Category", b =>
                {
                    b.Property<Guid>("bookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("categoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("bookId", "categoryId");

                    b.HasIndex("categoryId");

                    b.ToTable("book_category", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Book_Images", b =>
                {
                    b.Property<Guid>("imageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("bookId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("imageId", "bookId");

                    b.HasIndex("bookId");

                    b.ToTable("book_images", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Cart", b =>
                {
                    b.Property<Guid>("IdCart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("IdCart");

                    b.ToTable("cart");
                });

            modelBuilder.Entity("BookStore.Model.Cart_Book", b =>
                {
                    b.Property<Guid>("bookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cartId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("bookId", "cartId");

                    b.HasIndex("cartId");

                    b.ToTable("cart_book", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("customer", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Customer_Book", b =>
                {
                    b.Property<Guid>("bookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("customerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("bookId", "customerId");

                    b.HasIndex("customerId");

                    b.ToTable("customer_book", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Employee", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("employee", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Images", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<byte[]>("DataImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NameImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("images", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Role", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("BookStore.Model.Account", b =>
                {
                    b.HasOne("BookStore.Model.Customer", "customer")
                        .WithMany("accounts")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Model.Employee", "employee")
                        .WithMany("account")
                        .HasForeignKey("employeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("BookStore.Model.Account_Role", b =>
                {
                    b.HasOne("BookStore.Model.Account", "account")
                        .WithMany("account_Roles")
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Model.Role", "role")
                        .WithMany("account_Roles")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");

                    b.Navigation("role");
                });

            modelBuilder.Entity("BookStore.Model.Book_Category", b =>
                {
                    b.HasOne("BookStore.Model.Book", "book")
                        .WithMany("book_Categories")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Model.Category", "category")
                        .WithMany("book_Categories")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("category");
                });

            modelBuilder.Entity("BookStore.Model.Book_Images", b =>
                {
                    b.HasOne("BookStore.Model.Book", "book")
                        .WithMany("book_Images")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Model.Images", "image")
                        .WithMany("book_Images")
                        .HasForeignKey("imageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("image");
                });

            modelBuilder.Entity("BookStore.Model.Cart_Book", b =>
                {
                    b.HasOne("BookStore.Model.Book", "book")
                        .WithMany("cart_Books")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Model.Cart", "cart")
                        .WithMany("cart_Books")
                        .HasForeignKey("cartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("cart");
                });

            modelBuilder.Entity("BookStore.Model.Customer_Book", b =>
                {
                    b.HasOne("BookStore.Model.Book", "book")
                        .WithMany("customer_Books")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Model.Customer", "customer")
                        .WithMany("customer_Books")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("customer");
                });

            modelBuilder.Entity("BookStore.Model.Account", b =>
                {
                    b.Navigation("account_Roles");
                });

            modelBuilder.Entity("BookStore.Model.Book", b =>
                {
                    b.Navigation("book_Categories");

                    b.Navigation("book_Images");

                    b.Navigation("cart_Books");

                    b.Navigation("customer_Books");
                });

            modelBuilder.Entity("BookStore.Model.Cart", b =>
                {
                    b.Navigation("cart_Books");
                });

            modelBuilder.Entity("BookStore.Model.Category", b =>
                {
                    b.Navigation("book_Categories");
                });

            modelBuilder.Entity("BookStore.Model.Customer", b =>
                {
                    b.Navigation("accounts");

                    b.Navigation("customer_Books");
                });

            modelBuilder.Entity("BookStore.Model.Employee", b =>
                {
                    b.Navigation("account");
                });

            modelBuilder.Entity("BookStore.Model.Images", b =>
                {
                    b.Navigation("book_Images");
                });

            modelBuilder.Entity("BookStore.Model.Role", b =>
                {
                    b.Navigation("account_Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
