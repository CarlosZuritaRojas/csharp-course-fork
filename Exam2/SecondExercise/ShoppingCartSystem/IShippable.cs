namespace ShoppingCartSystem;

public interface IShippable
{
    decimal Weight { get; }
    void Ship();
    decimal CalculateShippingCost();
}
