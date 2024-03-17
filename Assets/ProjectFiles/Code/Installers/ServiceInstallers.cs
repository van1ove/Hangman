using ProjectFiles.Code.Services.Factories.KeyboardItemFactory;
using ProjectFiles.Code.Services.Loaders.AssetProvider;
using Zenject;

namespace ProjectFiles.Code.Installers
{
    public class ServiceInstallers : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindAssetsProvider();
            BindKeyboardItemFactory();
        }

        private void BindAssetsProvider() => 
            Container.BindInterfacesTo<AssetProvider>().AsSingle();

        private void BindKeyboardItemFactory() =>
            Container.BindInterfacesTo<KeyboardItemFactory>().AsSingle();
    }
}