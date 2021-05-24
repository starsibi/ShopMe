using System.Collections.Generic;

namespace ShopMe.BusinessLayer.Interfaces
{
    public interface ICalculateCartFlow
    {
        CartModel Calculate(List<Product> products);
    }
}
