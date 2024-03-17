using UnityEngine;

namespace ProjectFiles.Code.Services.Loaders.AssetProvider
{
    public interface IAssetProvider : IService
    {
        GameObject LoadAsset(string path);
    }
}