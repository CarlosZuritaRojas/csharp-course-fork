using ReportGenerationSystem.Enums;
using ReportGenerationSystem.Interfaces;

namespace ReportGenerationSystem.Strategies;

public class JSONFormatStrategy : IReportFormatStrategy
{
     public FormatType GetFormatName() => FormatType.Json;

    public string GetFileExtension() => ".json";

    public string FormatReport(List<string> processedData, ReportType reportType)
    {
        Console.WriteLine($"Formatting {reportType} report as JSON ...");

        var JSON = "{\n";
        JSON += "Items: ";
        if ( processedData.Count > 0 )
        {
            JSON += " [\n";

            for (var i  = 0; i < processedData.Count(); i++)
            {
                JSON += $"\t{processedData[i]}";
                if (i != processedData.Count() - 1)
                {
                    JSON += ",\n";
                }
            }
            JSON += "\n\t]\n}\n\n";
        }
        else
        {
            JSON += "null\n}\n\n";
        }

        return JSON;
    }
}