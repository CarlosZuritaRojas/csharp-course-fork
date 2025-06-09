namespace ShoppingCartSystem;

public class PhysicalProduct : IProduct, IShippable
{
  public string? Name { get; set; }
  public decimal Price { get; set; }
  public int Stock { get; set; }
  public decimal Weight { get; set; }

  public void Ship()
  {
    if (Stock <= 0)
    {
      throw new InvalidOperationException("Product out of stock!");
    }

    Console.WriteLine($"Shipping {Name}");
    Stock--;
  }

  public decimal CalculateShippingCost() => Weight * 2.5m;
}
