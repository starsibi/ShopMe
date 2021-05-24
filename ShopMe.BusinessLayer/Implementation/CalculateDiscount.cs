using ShopMe.BusinessLayer.Interfaces;

namespace ShopMe.BusinessLayer.Implementation
{
    public class CalculateDiscount : ICalculateDiscount
    {
        public decimal GetDiscount(decimal SubTotal)
        {
            decimal discount = 0;

            if (SubTotal < 10000)
            {
                discount = SubTotal * 20 / 100;
            }
            else if(SubTotal >= 10000 && SubTotal <= 15000)
            {
                discount = SubTotal * 15 / 100;
            }
            else
            {
                discount = SubTotal * 10 / 100;
            }

            return discount;
        }
    }
}
