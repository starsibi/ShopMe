using ShopMe.BusinessLayer;
using System.Collections.Generic;

namespace ShopMe.Models
{
    public class CartViewModel
    {
        public List<Product> Products { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Discount { get; set; }

        public decimal Total { get; set; }

    }
}