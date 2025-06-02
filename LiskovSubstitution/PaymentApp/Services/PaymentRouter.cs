using PaymentApp.Interfaces;

namespace PaymentApp.Services;

public class PaymentRouter(IEnumerable<ICharger> chargers, IEnumerable<IRefunder> refunders) : IPaymentRouter
{
  private readonly Dictionary<string, ICharger> _chargers = chargers.ToDictionary(c => c.GetType().Name[..^7].ToLower());
  private readonly Dictionary<string, IRefunder> _refunders = refunders.ToDictionary(r => r.GetType().Name[..^7].ToLower());

  public void Charge(string method, decimal amount, string reference)
  {
    _chargers[method].Charge(amount, reference);
  }

  // TODO: Enhance this method apply simple Single Responsibility Principle
  public bool TryRefund(string method, decimal amount, string reference)
  {
    var refunder = GetRefunder(method);

    if (refunder is not null)
    {
      ProcessRefund(refunder, amount, reference);
    }
    else
    {
      ShowRefundNotSupportedMessage(method);
      return false;
    }

    return true;
  }

  private IRefunder? GetRefunder(string method)
  {
      _refunders.TryGetValue(method, out var refunder);
      return refunder;
  }
    
  private static void ProcessRefund(IRefunder refunder, decimal amount, string reference)
  {
      refunder.Refund(amount, reference);
  }

  private static void ShowRefundNotSupportedMessage(string method)
  {
    Console.WriteLine($"Refund not supported for method {method}.");
  }
}