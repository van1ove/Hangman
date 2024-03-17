using ProjectFiles.Code.Services.Factories.LetterItemFactory;
using ProjectFiles.Code.Services.Loaders.AssetProvider;
using ProjectFiles.Code.UI;
using ProjectFiles.Code.UI.Models;
using UnityEngine;

namespace ProjectFiles.Code.Services.Factories.WordFactory
{
    public class LetterItemFactory : ILetterItemFactory
    {
        private readonly IAssetProvider _assetProvider;

        public LetterItemFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }
        public LetterItem CreateLetterItem()
        {
            GameObject letterItem = _assetProvider.LoadAsset(AssetsPaths.LetterItemPath);
            return letterItem.GetComponent<LetterItem>();
        }
    }
}