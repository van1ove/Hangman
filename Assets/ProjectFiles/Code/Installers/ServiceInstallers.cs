using ProjectFiles.Code.Services.Factories;
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
        }

        private void BindAssetsProvider() => 
            Container.BindInterfacesTo<AssetProvider>().AsSingle();

        private void BindComponentFactory() =>
            Container.BindInterfacesTo<ComponentFactory>().AsSingle();
    }
}