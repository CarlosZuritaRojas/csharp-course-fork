namespace ShoppingCartSystem.Models.Interfaces;

public interface IProduct
{
    string? Name { get; set; }
    decimal Price { get; set; }
}