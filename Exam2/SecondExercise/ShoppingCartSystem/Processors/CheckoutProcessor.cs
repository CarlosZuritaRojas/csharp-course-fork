using ShoppingCartSystem.Models.Interfaces;

namespace ShoppingCartSystem.Processors;

public class CheckoutProcessor
{
    public void Checkout(IEnumerable<IProduct> items)
    {
        Console.WriteLine("\n=== Checkout Process ===");
        foreach (var item in items)
        {
            if (item is IShippable shippable)
            {
                shippable.Ship();
                Console.WriteLine($"- {item.Name}: Shipped (Weight: {shippable.Weight})");
            }

            if (item is IDownlodable downlodable)
            {
                downlodable.Download();
                Console.WriteLine($"- {item.Name}: Downloaded");
            }
        }
    }
}
