using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.DatabaseContext
{
    public class ShopDbinitializer
    {
        public class ShopDbinitializer : DropCreateDatabaseIfModelChanges<ShopDbContext>
        {
            protected override void Seed(ShopDbContext context)
            {
                context.Items.AddOrUpdate(x => x.Name,
                new Item
                {
                    Name = "Jeans",
                    
                };

                
            }
        }
    }
}