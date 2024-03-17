using ProjectFiles.Code.ScriptableObjects.TextField;
using Zenject;

namespace ProjectFiles.Code.Installers
{
    public class TextInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindTextsModel();
        }
        
        private void BindTextsModel() => Container.Bind<TextsCollectionModel>().AsSingle();
    }
}