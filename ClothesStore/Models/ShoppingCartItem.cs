using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.Models
{
    public class ShoppingCartItem
    {
        public Guid ShopingCartItemId { get; set; }
        public virtual Item Item { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public int Quantity { get; set; }

        public ShoppingCartItem ()
        {
            ShopingCartItemId = Guid.NewGuid();
            Quantity = 0;
        }

    }
}