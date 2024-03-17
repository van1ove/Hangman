using ProjectFiles.Code.Services.Loaders.AssetProvider;
using ProjectFiles.Code.UI;
using UnityEngine;

namespace ProjectFiles.Code.Services.Factories.KeyboardItemFactory
{
    public class KeyboardItemFactory : IKeyboardItemFactory
    {
        private readonly IAssetProvider _assetsProvider;

        public KeyboardItemFactory(IAssetProvider assetsProvider)
        {
            _assetsProvider = assetsProvider;
        }
        public KeyboardItem CreateKeyboardItem()
        {
            GameObject keyboardItemObject = _assetsProvider.LoadAsset(AssetsPaths.KeyboardItemPath);
            return keyboardItemObject.GetComponent<KeyboardItem>();
        }
    }
}