using System;
using System.Collections.Generic;
using ProjectFiles.Code.Consts;
using ProjectFiles.Code.Models.Entities;
using ProjectFiles.Code.Models.PrefabModels;
using ProjectFiles.Code.Services.Loaders.AssetProvider;
using ProjectFiles.Code.UI.Models;

namespace ProjectFiles.Code.Services.Factories
{
    public class ComponentFactory : IComponentFactory
    {
        private readonly IAssetProvider _assetProvider;
        private readonly Dictionary<Type, string> _assetsDictionary = new Dictionary<Type, string>()
        {
            [typeof(KeyboardItem)] = AssetsPaths.KeyboardItemPath,
            [typeof(LetterItem)] = AssetsPaths.LetterItemPath,
            [typeof(Keyboard)] = AssetsPaths.KeyboardPath,
            [typeof(Word)] = AssetsPaths.LettersListPath,
            [typeof(Hangman)] = AssetsPaths.HangmanPath,
            [typeof(GameRestarter)] = AssetsPaths.GameRestartPath
        };    

        public ComponentFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }
        
        public T CreateComponentFromPrefab<T>() where T : IEntity
        {
            return _assetProvider.LoadAsset<T>(_assetsDictionary[typeof(T)]);
        }
    }
}