using ShoppingCartSystem.Models.Interfaces;
using ShoppingCartSystem.Processors.Interfaces;

namespace ShoppingCartSystem.Processors;

public class DefaultDiscountStrategy : IDiscountStrategy
{
    private static int MinSubTotalToGetDiscount => 100;
    private static int MaxQuantityToDiscount => 5;
    public decimal ApplyDiscount(IEnumerable<IProduct> items, decimal subtotal)
    {
        decimal discount = 0;
        if (subtotal > MinSubTotalToGetDiscount) discount += subtotal * 0.1m;
        if (items.Count() > MaxQuantityToDiscount) discount += 5;
        return discount;
    }
}
