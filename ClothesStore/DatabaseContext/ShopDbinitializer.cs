using ClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using static ClothesStore.Models.Article;

namespace ClothesStore.DatabaseContext
{
    public class ShopDbInitializer : DropCreateDatabaseIfModelChanges<ShopDbContext>
    {
        protected override void Seed(ShopDbContext context)
        {
            context.Articles.AddOrUpdate(
                x => x.Name,
                new Article
                {
                    Name = "Mens Jeans",
                    Category = CategoryEnum.Men,
                    Price = 55,
                    AvailableSizes = "XS S M L XL"

                },
                new Article
                {
                    Name = "Womens Jeans",
                    Category = CategoryEnum.Women,
                    Price = 40,
                    AvailableSizes = "XS S M L XL"
                },
                new Article
                {
                    Name = "Kids Jeans",
                    Category = CategoryEnum.Kids,
                    Price = 25,
                    AvailableSizes = "XS S M L XL"
                },
                new Article
                {
                    Name = "Mens Jacket",
                    Category = CategoryEnum.Men,
                    Price = 80,
                    AvailableSizes = "XS S M L XL"
                },
                new Article
                {
                    Name = "Womens Jacket",
                    Category = CategoryEnum.Women,
                    Price = 90,
                    AvailableSizes = "XS S M L XL"
                },
                new Article
                {
                    Name = "Kids Jacket",
                    Category = CategoryEnum.Kids,
                    Price = 55,
                    AvailableSizes = "XS S M L XL"
                },
                new Article
                {
                    Name = "Mens Tops",
                    Category = CategoryEnum.Men,
                    Price = 60,
                    AvailableSizes = "XS S M L XL"
                },
                new Article
                {
                    Name = "Womens Tops",
                    Category = CategoryEnum.Women,
                    Price = 50,
                    AvailableSizes = "XS S M L XL"
                },
                new Article
                {
                    Name = "Kids Tops",
                    Category = CategoryEnum.Kids,
                    Price = 35,
                    AvailableSizes = "XS S M L XL"
                }
                );
        }
    }
}