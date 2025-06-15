using ReportGenerationSystem.Enums;

namespace ReportGenerationSystem.Interfaces;

public interface IReportFormatStrategy
{
  // TODO: Change to enum DONE
  FormatType GetFormatName();
  string FormatReport(List<string> processedData, ReportType reporType);
  string GetFileExtension();
}