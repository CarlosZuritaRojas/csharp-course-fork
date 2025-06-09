
namespace ShoppingCartSystem;

public class DefaultDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(IEnumerable<IProduct> items, decimal subtotal)
    {
        decimal discount = 0;
        if (subtotal > 100) discount += subtotal * 0.1m;
        if (items.Count() > 5) discount += 5;
        return discount;
    }
}
