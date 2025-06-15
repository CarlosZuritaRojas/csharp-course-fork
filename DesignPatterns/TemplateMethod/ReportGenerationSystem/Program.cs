using ReportGenerationSystem.Enums;
using ReportGenerationSystem.Services;

var reportService = new ReportService();
reportService.GenerateAllReports();
reportService.GenerateAllReportsInFormat(FormatType.Csv);
reportService.GenerateAllReportsInFormat(FormatType.Json);
