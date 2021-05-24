using ShopMe.BusinessLayer.Interfaces;

namespace ShopMe.BusinessLayer.Implementation
{
    public class CalculateTotal : ICalculateTotal
    {
        public decimal GetTotal(decimal subtotal, decimal tax, decimal discount)
        {
            return subtotal + tax - discount;
        }
    }
}
