using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.Models
{
    public class Item
    {
        public Guid ItemID { get; set; }

        public virtual Article Article { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }

        public Item()
        {
            ItemID = Guid.NewGuid();
        }
    }
}