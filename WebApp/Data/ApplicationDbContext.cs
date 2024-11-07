using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Nuts" },
                new Category { CategoryId = 2, Name = "Bolts" },
                new Category { CategoryId = 3, Name = "Cover Plate" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product {
                    ProductId = 1,
                    Name = "Nut-2.0",
                    Description = "Nut of a size of 2.0mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Nut-2.5",
                    Description = "Nut of a size of 2.5mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Nut-3.0",
                    Description = "Nut of a size of 3.0mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Nut-3.5",
                    Description = "Nut of a size of 3.5mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 1
                },


                new Product {
                    ProductId = 5,
                    Name = "Bolt-2.0",
                    Description = "Bolt of a size of 2.0mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Bolt-2.5",
                    Description = "Bolt of a size of 2.5mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Bolt-3.0",
                    Description = "Bolt a size of 3.0mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Bolt-3.5",
                    Description = "Bolt of a size of 3.5mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 2
                },


                new Product
                {
                    ProductId = 9,
                    Name = "Cover Plate-2.0",
                    Description = "Cover Plate of a size of 2.0mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Cover Plate-2.5",
                    Description = "Cover Plate of a size of 2.5mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 11,
                    Name = "Cover Plate-3.0",
                    Description = "Cover Plate of a size of 3.0mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 12,
                    Name = "Cover Plate 3.5",
                    Description = "Cover Plate of a size of 3.5mm",
                    Price = 0,
                    Stock = 100,
                    CategoryId = 3
                }
                );
        }
        }

    }
