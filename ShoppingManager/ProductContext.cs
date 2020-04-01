using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ShoppingManager
{
   

    class ProductContext : DbContext
    {
        public ProductContext()
            : base("DbConnection")
        { }

       public DbSet<Product> Products { get; set; } //таблица с продуктами
    }
}
