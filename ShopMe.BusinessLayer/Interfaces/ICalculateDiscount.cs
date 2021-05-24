namespace ShopMe.BusinessLayer.Interfaces
{
    public interface ICalculateDiscount
    {
        decimal GetDiscount(decimal SubTotal);
    }
}
