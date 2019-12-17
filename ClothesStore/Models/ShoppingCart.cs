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
		public void AddToCart(Article article)
		{
            Item newItem = new Item();
            Items.Add(newItem);
            newItem.Article = article;
            Sum += article.Price;
		}

        public void MakeTransaction()
        {
            IsPaid = true;
        }

        public void RemoveFromCart(Item item)
        {
            Items.Remove(item);
            Sum -= item.Article.Price;
        }
    }
}