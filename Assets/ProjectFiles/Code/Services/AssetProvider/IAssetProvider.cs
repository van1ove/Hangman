namespace ProjectFiles.Code.Services.Loaders.AssetProvider
{
    public interface IAssetProvider : IService
    {
        T LoadAsset<T> (string path);
    }
}