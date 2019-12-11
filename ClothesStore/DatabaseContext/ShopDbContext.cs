using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.DatabaseContext
{
    public class ShopDbContext
    {
        public class ShopDbContext : DbContext
        {
            public DbSet<Item> Items { get; set; }
            public DbSet<ShoppingCart> ShoppingCarts { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }
}