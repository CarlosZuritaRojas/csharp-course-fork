using ReportGenerationSystem.Enums;
using ReportGenerationSystem.Interfaces;
using ReportGenerationSystem.Strategies;

namespace ReportGenerationSystem.Factories;

public static class FormatStrategyFactory
{
  // TODO: Implement the missing format (json) DONE
  public static IReportFormatStrategy CreateStrategy(FormatType formatName)
  {
    return formatName switch
    {
      FormatType.Html => new HTMLFormatStrategy(),
      FormatType.Csv => new CSVFormatStrategy(),
      FormatType.Json => new JSONFormatStrategy(),
      _ => throw new ArgumentException($"Unknown format: {formatName}")
    };
  }

  // TODO: Find a cleaner way to do this DONE
  public static List<FormatType> GetAvailableFormats()
  {
     return [.. Enum.GetValues<FormatType>()];
  }
}