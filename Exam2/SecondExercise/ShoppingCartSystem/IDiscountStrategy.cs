namespace ShoppingCartSystem;

public interface IDiscountStrategy
{
    decimal ApplyDiscount (IEnumerable<IProduct> items, decimal subtotal);
}
