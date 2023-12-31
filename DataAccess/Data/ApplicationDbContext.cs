﻿using Entity_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genre { get; set; }

        public DbSet<BookDetail> BookDetails { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=localhost;Database=EntityTutorial;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);
            var bookList = new Book[]
            {
                new Book()
                {
                    bookId = 1,
                    Title = "Kingdom Power",
                    ISBN = "312",
                    Price = 312.21M,
                    PublisherId = 1
                },
                new Book()
                {
                    bookId = 2,
                    Title = "Prayer & Fasting",
                    ISBN = "697",
                    Price = 642.21M,
                    PublisherId = 3
                },
            };

            var pubilsherList = new Publisher[]
            {
                new Publisher()
                {
                    PublisherId = 1,
                    Name = "Cengage",
                    Location = "North America"
                },
                new Publisher()
                {
                    PublisherId = 2,
                    Name = "Darkwa Publication",
                    Location = "Canada"
                },
                new Publisher()
                {
                    PublisherId = 3,
                    Name = "Seemzy Publication",
                    Location = "Dubai"
                }
            };

            modelBuilder.Entity<Publisher>().HasData(pubilsherList);
            modelBuilder.Entity<Book>().HasData(bookList);
        }
    }
}
