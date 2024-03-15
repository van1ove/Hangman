using ProjectFiles.Code.Services.Interfaces;
using UnityEngine;

namespace ProjectFiles.Code.Services.Classes
{
    public class AssetProvider : IAssetsProvider
    {
        public GameObject LoadAsset(string path) =>
            Resources.Load<GameObject>(path);
    }
}