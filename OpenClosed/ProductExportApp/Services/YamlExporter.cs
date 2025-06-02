using ProductExportApp.Interfaces;
using ProductExportApp.Models;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace ProductExportApp.Services;

public class YamlExporter : IProductExporter
{
    public FormatType FormatKey => FormatType.Yaml;

    public string Export(IEnumerable<Product> products)
    {
        var serializer = new SerializerBuilder()
            .WithEnumNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();
        return serializer.Serialize(products);
    }
}
