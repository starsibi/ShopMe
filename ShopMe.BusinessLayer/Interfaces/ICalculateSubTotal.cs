using System.Collections.Generic;

namespace ShopMe.BusinessLayer.Interfaces
{
    public interface ICalculateSubTotal
    {
        decimal GetSubTotal(List<Product> products);
    }
}
