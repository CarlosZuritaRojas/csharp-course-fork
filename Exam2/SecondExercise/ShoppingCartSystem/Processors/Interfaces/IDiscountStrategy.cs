using ShoppingCartSystem.Models.Interfaces;

namespace ShoppingCartSystem.Processors.Interfaces;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(IEnumerable<IProduct> items, decimal subtotal);
}
