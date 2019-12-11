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
        public CategoryEnum Category;
        public List<string> AvailableSizes { get; set; }
        public double Price { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public Item()
        {
            AvailableSizes = new List<string>();
           /* {
                "XS", "S", "M", "L", "XL", "XXL"
            }; */

            ItemId = Guid.NewGuid();
        }
    }
}