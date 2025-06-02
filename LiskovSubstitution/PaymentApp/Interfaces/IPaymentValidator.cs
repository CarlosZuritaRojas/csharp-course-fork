using PaymentApp.Models;

namespace PaymentApp.Interfaces;

public interface IPaymentValidator
{
    public void ValidatePayment(Order order);
}
