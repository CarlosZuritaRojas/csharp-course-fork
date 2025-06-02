using ProductExportApp.Interfaces;
using ProductExportApp.Models;

namespace ProductExportApp.Services;

public class FormatTypeValidator : IFormatTypeValidator
{
    public FormatType ValidateFormatType(string formatType)
    {
        if (!Enum.TryParse(formatType, true, out FormatType formatMapped))
        {
            throw new NotSupportedException($"Export format '{formatType}' is not supported.");
        }

        return formatMapped;
    }
}
