using ProjectFiles.Code.Services.AssetProvider;
using ProjectFiles.Code.Services.ComponentFactory;
using ProjectFiles.Code.Services.DependencyFactory;
using ProjectFiles.Code.Services.GameWordsProvider;
using ProjectFiles.Code.Services.ProgressTracker;
using Zenject;

namespace ProjectFiles.Code.Installers
{
    public class ServiceInstallers : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindGameWordsProvider();
            BindProgressTracker();
            BindAssetsProvider();
            BindComponentFactory();
            BindDependencyFactory();
        }

        private void BindAssetsProvider() => 
            Container.BindInterfacesTo<AssetProvider>().AsSingle();

        private void BindComponentFactory() =>
            Container.BindInterfacesTo<ComponentFactory>().AsSingle();

        private void BindDependencyFactory() =>
            Container.BindInterfacesTo<DependencyFactory>().AsSingle();

        private void BindGameWordsProvider() =>
            Container.BindInterfacesTo<GameWordsProvider>().AsSingle();

        private void BindProgressTracker() =>
            Container.BindInterfacesTo<ProgressTracker>().AsSingle();
    }
}