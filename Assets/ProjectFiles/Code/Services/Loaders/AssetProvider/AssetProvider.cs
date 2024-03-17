using UnityEngine;

namespace ProjectFiles.Code.Services.Loaders.AssetProvider
{
    public class AssetProvider : IAssetProvider
    {
        public GameObject LoadAsset(string path) =>
            Resources.Load<GameObject>(path);
    }
}