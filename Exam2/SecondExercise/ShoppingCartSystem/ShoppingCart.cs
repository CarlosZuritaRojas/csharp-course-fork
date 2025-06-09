using ShoppingCartSystem.Models.Interfaces;
using ShoppingCartSystem.Processors.Interfaces;

namespace ShoppingCartSystem;

public class ShoppingCart(IDiscountStrategy discountStrategy, IShippingCalculator shippingCalculator) : IShoppingCart
{
  private readonly List<IProduct> _items = [];
  private readonly IDiscountStrategy _discountStrategy = discountStrategy;
  private readonly IShippingCalculator _shippingCalculator = shippingCalculator;

  public IEnumerable<IProduct> Items => _items;


  public void AddItem(IProduct product, int quantity = 1)
  {
    for (int i = 0; i < quantity; i++)
    {
      _items.Add(product);
    }

    Console.WriteLine($"Added {quantity} x {product.Name} to cart");
  }
  public decimal CalculateTotal()
  {
      var subtotal = _items.Sum(p => p.Price);
      var shipping = _shippingCalculator.CalculateShipping(_items);
      var discount = _discountStrategy.ApplyDiscount(_items, subtotal);
      return subtotal + shipping - discount;
  }

  public void DisplayCart()
  {
    Console.WriteLine("\n=== Shopping Cart ===");
    var grouped = _items.GroupBy(p => p.Name);

    foreach (var group in grouped)
    {
      var product = group.First();
      var quantity = group.Count();
      Console.WriteLine($"{product.Name} x{quantity} - ${product.Price * quantity:F2}");
    }
    Console.WriteLine($"Total: ${CalculateTotal():F2}");
  }
}
