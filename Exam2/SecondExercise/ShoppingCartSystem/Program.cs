namespace ShoppingCartSystem;

public class Program
{
  static void Main()
  {
    var cart = new ShoppingCart(new DefaultDiscountStrategy(), new DefaultShippingCalculator());

    var laptop = new PhysicalProduct
    {
      Name = "Gaming Laptop",
      Price = 1200,
      Stock = 5,
      Weight = 2.5m
    };

    var ebook = new DigitalProduct
    {
      Name = "Programming Guide",
      Price = 29.99m,
      DownloadUrl = "http://example.com/download/book.pdf"
    };

    var mouse = new PhysicalProduct
    {
      Name = "Wireless Mouse",
      Price = 25,
      Stock = 10,
      Weight = 0.2m
    };

    cart.AddItem(laptop);
    cart.AddItem(ebook);
    cart.AddItem(mouse, 2);

    cart.DisplayCart();

    var checkoutService = new CheckoutService();
    checkoutService.Checkout(cart.Items);

    Console.WriteLine($"\nTotal Amount: ${cart.CalculateTotal():F2}");
    Console.WriteLine("Payment processed successfully!");
    Console.WriteLine("Order confirmation sent to customer email.");
    }
}