using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.Models
{
    public class Item
    {
        public Guid ItemId { get; set; }
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
        public int Quantity { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public Item()
        {
            ItemId = Guid.NewGuid();
            Quantity = 0;
        }

    }
}