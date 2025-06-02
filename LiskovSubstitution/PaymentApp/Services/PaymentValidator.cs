using PaymentApp.Interfaces;
using PaymentApp.Models;

namespace PaymentApp.Services;

public class PaymentValidator(IEnumerable<ICharger> chargers) : IPaymentValidator
{
    private readonly Dictionary<string, ICharger> _chargers = chargers.ToDictionary(c => c.GetType().Name[..^7].ToLower());
    public void ValidatePayment(Order order)
    {
        if (string.IsNullOrEmpty(order.Id))
        {
            throw new ArgumentNullException($"The value of {nameof(order.Id)} field must not be null");
        }

        if (order.Amount < 0)
        {
            throw new ArgumentException("This amount of order, must be positive");
        }

        if (string.IsNullOrEmpty(order.Reference))
        {
            throw new ArgumentNullException($"The value of {nameof(order.Reference)} field must not be null");
        }

        if (!_chargers.TryGetValue(order.Method, out _))
        {
            throw new ArgumentException($"There is no a payment method named as {order.Method}");
        }
    }
}
