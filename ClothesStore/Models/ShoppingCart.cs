using System;
using System.Collections.Generic;

namespace ClothesStore.Models
{
    public class ShoppingCart
    {
        public Guid ShoppingcartId { get; set; }

        public DateTime DateCreated { get; set; }

        public Boolean IsPaid { get; set; }

        public double Sum { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public ShoppingCart()
        {
            ShoppingcartId = Guid.NewGuid();
            Sum = 0;
            DateCreated = DateTime.Now;
            Items = new List<Item>();
            //IsPaid = false;
        }
		public void AddToCart(Item item)
		{
			Items.Add(item);
			Sum += item.Price;
            item.Quantity++;
		}

        public void MakeTransaction()
        {
            IsPaid = true;
        }

        public void RemoveFromCart(Item item)
        {
            Items.Remove(item);
            Sum -= item.Price;
        }
    }
}