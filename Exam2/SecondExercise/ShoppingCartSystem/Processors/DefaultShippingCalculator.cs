using ShoppingCartSystem.Models.Interfaces;
using ShoppingCartSystem.Processors.Interfaces;

namespace ShoppingCartSystem.Processors;

public class DefaultShippingCalculator : IShippingCalculator
{
    public decimal CalculateShipping(IEnumerable<IProduct> items)
    {
        return items.OfType<IShippable>().Sum(p => p.CalculateShippingCost());
    }
}
