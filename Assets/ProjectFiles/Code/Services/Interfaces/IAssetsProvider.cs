using UnityEngine;

namespace ProjectFiles.Code.Services.Interfaces
{
    public interface IAssetsProvider : IService
    {
        GameObject LoadAsset(string path);
    }
}