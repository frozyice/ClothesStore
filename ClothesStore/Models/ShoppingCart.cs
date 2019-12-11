using System;
using System.Collections.Generic;

namespace ClothesStore.Models
{
    public class ShoppingCart
    {
        public Guid ShoppingcartId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool isPaid { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public ShoppingCart()
        {
            ShoppingcartId = Guid.NewGuid();
            DateCreated = DateTime.Now;

            Items = new List<Item>();
        }
    }
}