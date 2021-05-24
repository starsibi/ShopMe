using ShopMe.BusinessLayer.Interfaces;
using System.Collections.Generic;

namespace ShopMe.BusinessLayer.Implementation
{
    public class CalculateSubTotal : ICalculateSubTotal
    {
        public decimal GetSubTotal(List<Product> products)
        {
            decimal subtotal = 0;

            foreach(Product product in products)
            {
                subtotal = subtotal + product.Amount;
            }

            return subtotal;
        }
    }
}
