using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.Models
{
    public class Item
    {
        private string Name { get; set; }
        private enum Category
        {
            Men = 0,
            Women = 1,
            Kids = 2
        }
        private List<string> AvailableSizes { get; set; }
        private double Price { get; set; }

        public Item()
        {
            AvailableSizes = new List<string>
            {
                "XS", "S", "M", "L", "XL", "XXL"
            };
        }
    }
}