using ShoppingCartSystem.Models;
using ShoppingCartSystem.Models.Interfaces;
using ShoppingCartSystem.Processors;

namespace ShoppingCartSystem.Cli;

public class ShoppingCli(IShoppingCart shoppingCart)
{
    private readonly IShoppingCart shoppingCart = shoppingCart;

    public void Run()
    {
        var products = SampleProducts().ToList();
        shoppingCart.AddItem(products[0]);
        shoppingCart.AddItem(products[1]);
        shoppingCart.AddItem(products[2], 2);

        shoppingCart.DisplayCart();

        var checkoutService = new CheckoutProcessor();
        checkoutService.Checkout(shoppingCart.Items);

        Console.WriteLine($"\nTotal Amount: ${shoppingCart.CalculateTotal():F2}");
        Console.WriteLine("Payment processed successfully!");
        Console.WriteLine("Order confirmation sent to customer email.");
    }

    private static IEnumerable<IProduct> SampleProducts() 
    {
        IEnumerable<IProduct> products = [
            new PhysicalProduct {
                Name = "Gaming Laptop",
                Price = 1200,
                Stock = 5,
                Weight = 2.5m
            },
            new DigitalProduct
            {
                Name = "Programming Guide",
                Price = 29.99m,
                DownloadUrl = "http://example.com/download/book.pdf"
            },
            new PhysicalProduct
            {
                Name = "Wireless Mouse",
                Price = 25,
                Stock = 10,
                Weight = 0.2m
            }
        ];
        return products;
    }
}
