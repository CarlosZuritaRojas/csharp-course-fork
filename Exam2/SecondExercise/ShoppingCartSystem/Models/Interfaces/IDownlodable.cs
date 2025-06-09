namespace ShoppingCartSystem.Models.Interfaces;

public interface IDownlodable
{
    string? DownloadUrl { get; }
    void Download();
}
