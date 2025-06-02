using InvoiceApp.Interfaces;

namespace InvoiceApp.Services;

public class ArgumentValidator : IArgumentValidator
{
    public void CheckArguments(string [] args)
    {
        if (args.Length == 0)
        {
            throw new ArgumentException("Expecting JSON invoices!");
        }
    }
}
