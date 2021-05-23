using ShopMe.BusinessLayer.Interfaces;
using System.Collections.Generic;

namespace ShopMe.BusinessLayer.Implementation
{
    public class ProductDetails : IProductDetails
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Name = "Samsung s21",
                    Amount = 96000M
                },
                new Product
                {
                    Name = "Iphone 12",
                    Amount =  88000M
                },
                  new Product
                {
                    Name = "Oppo F11",
                    Amount = 42000M
                },
                new Product
                {
                    Name = "Nokia 8.1",
                    Amount =  18000M
                },
                 new Product
                {
                    Name = "Micromax z4",
                    Amount =  28000M
                }

            };

            return products;
        }
    }
}
