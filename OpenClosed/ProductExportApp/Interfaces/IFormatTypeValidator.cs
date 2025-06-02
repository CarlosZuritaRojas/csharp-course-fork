using ProductExportApp.Models;

namespace ProductExportApp.Interfaces;

public interface IFormatTypeValidator
{
    FormatType ValidateFormatType(string formatType);
}
