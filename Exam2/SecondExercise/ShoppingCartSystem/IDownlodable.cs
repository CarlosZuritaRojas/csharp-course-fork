namespace ShoppingCartSystem;

public interface IDownlodable
{
    string? DownloadUrl { get; }
    void Download();
}
