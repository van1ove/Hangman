﻿using ProjectFiles.Code.Consts;
using ProjectFiles.Code.Services.Factories;
using ProjectFiles.Code.Services.GameWordsProvider;
using ProjectFiles.Code.Services.Loaders.AssetProvider;
using Zenject;

namespace ProjectFiles.Code.Installers
{
    public class ServiceInstallers : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindAssetsProvider();
            BindComponentFactory();
            BindGameWordsProvider();
        }

        private void BindAssetsProvider() => 
            Container.BindInterfacesTo<AssetProvider>().AsSingle();

        private void BindComponentFactory() =>
            Container.BindInterfacesTo<ComponentFactory>().AsSingle();

        private void BindGameWordsProvider() =>
            Container.BindInterfacesTo<GameWordsProvider>().AsSingle();
    }
}