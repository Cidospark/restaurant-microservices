using System;
using Microsoft.EntityFrameworkCore;
using restaurant.ProductAPI.Models;

namespace restaurant.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samsung",
                Price = 150,
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, fugit qui tenetur, eius dolor sapiente corporis ex voluptas itaque omnis quos odio reprehenderit veniam eligendi! Dolore, corporis repellat! Nam, saepe!",
                ImageUrl = "https://cidosdotnetlearning.blob.core.windows.net/restaurantimgs/images.jpg",
                CategoryName = "Electronics"
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "School bag",
                Price = 50,
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, fugit qui tenetur, eius dolor sapiente corporis ex voluptas itaque omnis quos odio reprehenderit veniam eligendi! Dolore, corporis repellat! Nam, saepe!",
                ImageUrl = "https://cidosdotnetlearning.blob.core.windows.net/restaurantimgs/d0dc9d33e87883dba9ba2e115cdc7abce289f18c.webp",
                CategoryName = "Fashion"
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Snickers",
                Price = 250,
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, fugit qui tenetur, eius dolor sapiente corporis ex voluptas itaque omnis quos odio reprehenderit veniam eligendi! Dolore, corporis repellat! Nam, saepe!",
                ImageUrl = "https://cidosdotnetlearning.blob.core.windows.net/restaurantimgs/product-jpeg-500x500.webp",
                CategoryName = "Fashion"
            });
        } 
    }
}
