using ProjectFiles.Code.UI;
using UnityEngine;

namespace ProjectFiles.Code.Services.Factories.KeyboardItemFactory
{
    public interface IKeyboardItemFactory : IService
    {
        KeyboardItem CreateKeyboardItem();
    }
}