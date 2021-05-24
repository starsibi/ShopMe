using ShopMe.BusinessLayer.Interfaces;

namespace ShopMe.BusinessLayer.Implementation
{
    public class CalculateTax : ICalculateTax
    {
        public decimal GetTax(decimal subTotal)
        {
            return subTotal * 18 / 100;
        }
    }
}
