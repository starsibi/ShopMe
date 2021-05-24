using ShopMe.BusinessLayer.Interfaces;
using System.Collections.Generic;

namespace ShopMe.BusinessLayer.Implementation
{
    public class CalculateCartFlow : ICalculateCartFlow
    {
        private readonly ICalculateSubTotal calculateSubTotal;
        private readonly ICalculateTax calculateTax;
        private readonly ICalculateDiscount calculateDiscount;
        private readonly ICalculateTotal calculateTotal;

        public CalculateCartFlow(ICalculateSubTotal calculateSubTotal, ICalculateTax calculateTax, ICalculateDiscount calculateDiscount, ICalculateTotal calculateTotal)
        {
            this.calculateSubTotal = calculateSubTotal;
            this.calculateTax = calculateTax;
            this.calculateDiscount = calculateDiscount;
            this.calculateTotal = calculateTotal;
        }


        public CartModel Calculate(List<Product> products)
        {
            CartModel cartModel = new CartModel();

            cartModel.SubTotal = calculateSubTotal.GetSubTotal(products);
            cartModel.Tax = calculateTax.GetTax(cartModel.SubTotal);
            cartModel.Discount = calculateDiscount.GetDiscount(cartModel.SubTotal);
            cartModel.Total = calculateTotal.GetTotal(cartModel.SubTotal, cartModel.Tax, cartModel.Discount);
            cartModel.Products = products;

            return cartModel;
        }
    }
}
