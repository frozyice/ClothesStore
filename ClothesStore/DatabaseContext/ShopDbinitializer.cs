using ClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using static ClothesStore.Models.Item;

namespace ClothesStore.DatabaseContext
{
    public class ShopDbInitializer : DropCreateDatabaseIfModelChanges<ShopDbContext>
    {
        protected override void Seed(ShopDbContext context) => context.Items.AddOrUpdate(x => x.Name,
                new Item
                {
                    Name = "Jeans",
                    Category = CategoryEnum.Men,
                    
                }
                );
    }
}