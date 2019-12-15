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
                    Name = "Jeans",
                    Category = CategoryEnum.Men,
                    Price = 55
                },
                new Item
                {
                    Name = "Jeans",
                    Category = CategoryEnum.Women,
                    Price = 40
                },
                new Item
                {
                    Name = "Jeans",
                    Category = CategoryEnum.Kids,
                    Price = 25
                },
                new Item
                {
                    Name = "Jacket",
                    Category = CategoryEnum.Men,
                    Price = 80
                },
                new Item
                {
                    Name = "Jacket",
                    Category = CategoryEnum.Women,
                    Price = 90
                },
                new Item
                {
                    Name = "Jacket",
                    Category = CategoryEnum.Kids,
                    Price = 55
                },
                new Item
                {
                    Name = "Shoes",
                    Category = CategoryEnum.Men,
                    Price = 60
                },
                new Item
                {
                    Name = "Shoes",
                    Category = CategoryEnum.Women,
                    Price = 50
                },
                new Item
                {
                    Name = "Shoes",
                    Category = CategoryEnum.Kids,
                    Price = 35
                }
                );
        }
    }
}