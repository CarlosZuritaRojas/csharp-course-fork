using ShoppingCartSystem.Models.Interfaces;

namespace ShoppingCartSystem.Models;

public class DigitalProduct : IProduct, IDownlodable
{
    public string? DownloadUrl { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public void Download()
    {
        Console.WriteLine($"Downloading {Name} from {DownloadUrl}");
    }
}