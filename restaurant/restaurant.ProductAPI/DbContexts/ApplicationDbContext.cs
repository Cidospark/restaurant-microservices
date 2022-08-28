﻿using System;
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
    }
}
