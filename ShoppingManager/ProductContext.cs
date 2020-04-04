using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ShoppingManager
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; } //таблица с продуктами
    }
}
