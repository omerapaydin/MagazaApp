using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagazaApp.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagazaApp.Data.Concrete.EfCore
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
          : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Comment> Comments => Set<Comment>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(w => 
                w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var user1 = new ApplicationUser
            {
                Id = "1",
                UserName = "omerapaydin",
                NormalizedUserName = "OMERAPAYDIN",
                Email = "info@gmail.com",
                NormalizedEmail = "INFO@GMAIL.COM",
                ImageFile = "p1.jpg",
                FullName = "Ömer Apaydın",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEJnKZpP8mHj4vdV6uFh8QZ7YvR3b+..." // sabit hash
            };

            var user2 = new ApplicationUser
            {
                Id = "2",
                UserName = "ahmettambuga",
                NormalizedUserName = "AHMETTAMBUGA",
                Email = "info2@gmail.com",
                NormalizedEmail = "INFO2@GMAIL.COM",
                ImageFile = "p2.jpg",
                FullName = "Ahmet Tamboğa",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEOTZQsc3HFxSklKuQyCk1M..." // sabit hash
            };

            modelBuilder.Entity<ApplicationUser>().HasData(user1, user2);

            // Kategoriler
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Eşarp" },
                new Category { CategoryId = 2, Name = "Şal" },
                new Category { CategoryId = 3, Name = "Aksesuarlar" }
            );

            // Ürünler
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Title = "Eşarp",
                    Description = "Siyah Uzun Eşarp",
                    PublishedOn = new DateTime(2024, 1, 1),
                    Image = "esarp1.jpg",
                    Price = 45000,
                    IsActive = true,
                    UserId = "1",
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 2,
                    Title = "Eşarp",
                    Description = "Siyah Uzun Eşarp",
                    PublishedOn = new DateTime(2024, 2, 1),
                    Image = "esarp2.jpg",
                    Price = 55000,
                    IsActive = true,
                    UserId = "1",
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 3,
                    Title = "Eşarp",
                    Description = "Siyah Uzun Eşarp",
                    PublishedOn = new DateTime(2024, 3, 1),
                    Image = "esarp3.jpg",
                    Price = 75000,
                    IsActive = true,
                    UserId = "2",
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 4,
                    Title = "Eşarp",
                    Description = "Siyah Uzun Eşarp",
                    PublishedOn = new DateTime(2024, 3, 1),
                    Image = "esarp4.jpg",
                    Price = 75000,
                    IsActive = true,
                    UserId = "2",
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 5,
                    Title = "Şal",
                    Description = "Siyah Uzun Eşarp",
                    PublishedOn = new DateTime(2024, 3, 1),
                    Image = "esarp5.jpg",
                    Price = 75000,
                    IsActive = true,
                    UserId = "2",
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 6,
                    Title = "Şal",
                    Description = "Siyah Uzun Eşarp",
                    PublishedOn = new DateTime(2024, 3, 1),
                    Image = "esarp6.jpg",
                    Price = 75000,
                    IsActive = true,
                    UserId = "2",
                    CategoryId = 3
                }
            );
        }

    }
}