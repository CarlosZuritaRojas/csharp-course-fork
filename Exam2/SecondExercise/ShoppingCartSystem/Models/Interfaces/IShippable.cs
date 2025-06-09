namespace ShoppingCartSystem.Models.Interfaces;

public interface IShippable
{
    decimal Weight { get; }
    void Ship();
    decimal CalculateShippingCost();
}
