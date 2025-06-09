namespace ShoppingCartSystem;

public class CheckoutService
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
