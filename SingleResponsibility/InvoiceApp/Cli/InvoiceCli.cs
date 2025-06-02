using InvoiceApp.Interfaces;

namespace InvoiceApp.Cli;

public class InvoiceCli(
  IInvoiceParser invoiceParser,
  IInvoiceCalculator invoiceCalculator,
  IReportFormatter reportFormatter,
  IArgumentValidator invoiceValidator
  )
{
  private readonly IInvoiceParser _invoiceParser = invoiceParser;
  private readonly IInvoiceCalculator _invoiceCalculator = invoiceCalculator;
  private readonly IReportFormatter _reportFormatter = reportFormatter;
  private readonly IArgumentValidator _invoiceValidator = invoiceValidator;

  public void Run(string[] args)
  {
    // TODO: Create validator, create as a service DONE
    _invoiceValidator.CheckArguments(args);
    var json = args[0];
    var invoices = _invoiceParser.Parse(json);
    var (total, average) = _invoiceCalculator.Calculate(invoices);
    var report = _reportFormatter.Format(invoices, total, average);

    Console.WriteLine(report);
  }
}