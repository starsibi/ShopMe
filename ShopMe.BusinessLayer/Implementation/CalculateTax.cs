using ShopMe.BusinessLayer.Interfaces;

namespace ShopMe.BusinessLayer.Implementation
{
    public class CalculateTax : ICalculateTax
    {
        decimal ICalculateTax.CalculateTax(decimal subTotal)
        {
            return subTotal * 18 / 100;
        }
    }
}
