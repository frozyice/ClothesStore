using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.Models
{
    public class Article
    {
        public Guid ArticleId { get; set; }
        public string Name { get; set; }
        public enum CategoryEnum
        {
            Men = 0,
            Women = 1,
            Kids = 2
        }
        public CategoryEnum Category { get; set; }
        public string AvailableSizes { get; set; }
        public double Price { get; set; }


        public virtual ICollection<Item> Items { get; set; }

        public Article()
        {
            ArticleId = Guid.NewGuid();
        }

    }
}