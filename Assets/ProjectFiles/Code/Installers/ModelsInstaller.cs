using ProjectFiles.Code.Consts;
using ProjectFiles.Code.Models;
using ProjectFiles.Code.ScriptableObjects.TextField;
using Zenject;

namespace ProjectFiles.Code.Installers
{
    public class ModelsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindTextsCollectionModel();
            BindGameWordsModel();
            BindGameDataModel();
        }
        
        private void BindTextsCollectionModel() => Container.Bind<TextsCollectionModel>().AsSingle();
        
        private void BindGameWordsModel() => Container.Bind<GameWords>().AsSingle();

        private void BindGameDataModel() => Container.Bind<GameDataModel>().AsSingle();
    }
}