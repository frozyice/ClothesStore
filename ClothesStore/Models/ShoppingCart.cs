using System;
using System.Collections.Generic;

namespace ClothesStore.Models
{
    public class ShoppingCart
    {
        public Guid ShoppingcartId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool isPaid { get; set; }
        public double Sum;

        public virtual ICollection<Item> Items { get; set; }

        public ShoppingCart()
        {
            ShoppingcartId = Guid.NewGuid();
            Sum = 0;
            DateCreated = DateTime.Now;
            Items = new List<Item>();
        }
		public void AddToCart(Item item)
		{
			Items.Add(item);
			Sum += item.Price;
		}
    }
}