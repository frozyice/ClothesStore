using System;
using System.Collections.Generic;

namespace ClothesStore.Models
{
    public class ShoppingCart
    {
        private Guid ShoppingcartId { get; set; }
        private DateTime DateCreated { get; set; }
        private bool isPaid { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public ShoppingCart()
        {
            ShoppingcartId = Guid.NewGuid();
            DateCreated = DateTime.Now;

            Items = new List<Item>();
        }
    }
}