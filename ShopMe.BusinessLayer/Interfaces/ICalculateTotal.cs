namespace ShopMe.BusinessLayer.Interfaces
{
    public interface ICalculateTotal
    {
        decimal GetTotal(decimal subtotal, decimal tax, decimal discount);
    }
}
