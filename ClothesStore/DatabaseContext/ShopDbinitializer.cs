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
                    AvailableSizes = "XS S M XL"
                    
                },
                new Item
                {
                    Name = "Womens Jeans",
                    Category = CategoryEnum.Women,
                    Price = 40,
                    AvailableSizes = "XS S M L"
                },
                new Item
                {
                    Name = "Kids Jeans",
                    Category = CategoryEnum.Kids,
                    Price = 25,
                    AvailableSizes = "XS S M"
                },
                new Item
                {
                    Name = "Mens Jacket",
                    Category = CategoryEnum.Men,
                    Price = 80,
                    AvailableSizes = "S M L XL"
                },
                new Item
                {
                    Name = "Womens Jacket",
                    Category = CategoryEnum.Women,
                    Price = 90,
                    AvailableSizes = "XS M L XL"
                },
                new Item
                {
                    Name = "Kids Jacket",
                    Category = CategoryEnum.Kids,
                    Price = 55,
                    AvailableSizes = "XS S M L XL"
                },
                new Item
                {
                    Name = "Mens Shoes",
                    Category = CategoryEnum.Men,
                    Price = 60,
                    AvailableSizes = "XS S M XL"
                },
                new Item
                {
                    Name = "Womens Shoes",
                    Category = CategoryEnum.Women,
                    Price = 50,
                    AvailableSizes = "XS S L XL"
                },
                new Item
                {
                    Name = "Kids Shoes",
                    Category = CategoryEnum.Kids,
                    Price = 35,
                    AvailableSizes = "XS S M L XL"
                }
                );
        }
    }
}