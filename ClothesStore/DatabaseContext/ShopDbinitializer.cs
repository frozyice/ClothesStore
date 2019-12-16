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
        protected override void Seed(ShopDbContext context)
        {
            context.Items.AddOrUpdate(
                x => x.Name,
                new Item
                {
                    Name = "Mens Jeans",
                    Category = CategoryEnum.Men,
                    Price = 55,
                    AvailableSizes = "M XL"
                    
                },
                new Item
                {
                    Name = "Womens Jeans",
                    Category = CategoryEnum.Women,
                    Price = 40
                },
                new Item
                {
                    Name = "Kids Jeans",
                    Category = CategoryEnum.Kids,
                    Price = 25
                },
                new Item
                {
                    Name = "Mens Jacket",
                    Category = CategoryEnum.Men,
                    Price = 80
                },
                new Item
                {
                    Name = "Womens Jacket",
                    Category = CategoryEnum.Women,
                    Price = 90
                },
                new Item
                {
                    Name = "Kids Jacket",
                    Category = CategoryEnum.Kids,
                    Price = 55
                },
                new Item
                {
                    Name = "Mens Shoes",
                    Category = CategoryEnum.Men,
                    Price = 60
                },
                new Item
                {
                    Name = "Womens Shoes",
                    Category = CategoryEnum.Women,
                    Price = 50
                },
                new Item
                {
                    Name = "Kids Shoes",
                    Category = CategoryEnum.Kids,
                    Price = 35
                }
                );
        }
    }
}