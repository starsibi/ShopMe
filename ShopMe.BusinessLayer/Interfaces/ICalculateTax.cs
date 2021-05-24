namespace ShopMe.BusinessLayer.Interfaces
{
    public interface ICalculateTax
    {
        decimal GetTax(decimal subTotal);
    }
}
