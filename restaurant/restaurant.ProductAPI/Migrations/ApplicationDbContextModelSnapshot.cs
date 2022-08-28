﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using restaurant.ProductAPI.DbContexts;

namespace restaurant.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("restaurant.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Electronics",
                            Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, fugit qui tenetur, eius dolor sapiente corporis ex voluptas itaque omnis quos odio reprehenderit veniam eligendi! Dolore, corporis repellat! Nam, saepe!",
                            ImageUrl = "https://cidosdotnetlearning.blob.core.windows.net/restaurantimgs/images.jpg",
                            Name = "Samsung",
                            Price = 150.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Fashion",
                            Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, fugit qui tenetur, eius dolor sapiente corporis ex voluptas itaque omnis quos odio reprehenderit veniam eligendi! Dolore, corporis repellat! Nam, saepe!",
                            ImageUrl = "https://cidosdotnetlearning.blob.core.windows.net/restaurantimgs/d0dc9d33e87883dba9ba2e115cdc7abce289f18c.webp",
                            Name = "School bag",
                            Price = 50.0
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Fashion",
                            Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sint, fugit qui tenetur, eius dolor sapiente corporis ex voluptas itaque omnis quos odio reprehenderit veniam eligendi! Dolore, corporis repellat! Nam, saepe!",
                            ImageUrl = "https://cidosdotnetlearning.blob.core.windows.net/restaurantimgs/product-jpeg-500x500.webp",
                            Name = "Snickers",
                            Price = 250.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
