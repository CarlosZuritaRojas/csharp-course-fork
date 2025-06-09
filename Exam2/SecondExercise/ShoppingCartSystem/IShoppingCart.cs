using ShoppingCartSystem.Models.Interfaces;

namespace ShoppingCartSystem;

public interface IShoppingCart
{
    IEnumerable<IProduct> Items { get; }

    void AddItem(IProduct product, int quantity = 1);

    decimal CalculateTotal();

    void DisplayCart();
}
