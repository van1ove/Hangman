using ProjectFiles.Code.UI.Models;

namespace ProjectFiles.Code.Services.Factories.KeyboardItemFactory
{
    public interface IKeyboardItemFactory : IService
    {
        KeyboardItem CreateKeyboardItem();
    }
}