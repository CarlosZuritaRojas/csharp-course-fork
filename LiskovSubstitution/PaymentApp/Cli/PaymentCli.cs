using System.Text.Json;
using PaymentApp.Interfaces;
using PaymentApp.Models;
using PaymentApp.Services;

namespace PaymentApp.Cli;

public class PaymentCli(IPaymentRouter paymentRouter, IPaymentValidator paymentValidator)
{
  private readonly IPaymentRouter _paymentRouter = paymentRouter;
    private readonly IPaymentValidator _paymentValidator = paymentValidator;

  public void Run(string[] args)
  {
    // TODO: Implement validation for input arguments DONE
    var json = args.Length > 0 ? args[0] : throw new ArgumentException("""
        Arguments are empty we need an input as json with the next structure 
        [
            {
              "id": string,
              "method": "bitcoin|creditcard|paypal",
              "amount": int,
              "reference": string
            }
        ]
        """);
    var orders = JsonSerializer.Deserialize<List<Order>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;

    foreach (var order in orders)
    {
      _paymentValidator.ValidatePayment(order);
      _paymentRouter.Charge(order.Method, order.Amount, order.Reference);
    }

    Console.WriteLine("\n--- Cancel & refund second order ---");

    var cancelledOrder = orders[1];
    _paymentRouter.TryRefund(cancelledOrder.Method, cancelledOrder.Amount, cancelledOrder.Reference);
  }

    // TODO: Delete this method and add validations DONE
   /* public static string SampleData()
    {
        return """
    [
      {
        "id": "A1",
        "method": "bitcoin",
        "amount": 100.00,
        "reference": "TX1234567890"
      },
      {
        "id": "B2",
        "method": "creditcard",
        "amount": 50.00,
        "reference": "CC1234567890"
      },
      {
        "id": "C3",
        "method": "paypal",
        "amount": 75.00,
        "reference": "PP1234567890"
      }
    ]
    """;
    }*/
}