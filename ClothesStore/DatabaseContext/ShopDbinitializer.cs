using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ClothesStore.DatabaseContext
{
    public class ShopDbinitializer : DropCreateDatabaseIfModelChanges<ShopDbContext>
    {
        protected override void Seed(ShopDbContext context)
        {
            context.Items.AddOrUpdate(x => x.Name,
                )
        }
    }
}