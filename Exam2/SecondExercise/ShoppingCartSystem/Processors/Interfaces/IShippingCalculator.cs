using ShoppingCartSystem.Models.Interfaces;

namespace ShoppingCartSystem.Processors.Interfaces;

public interface IShippingCalculator
{
    decimal CalculateShipping(IEnumerable<IProduct> items);
}
