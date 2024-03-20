using System.Collections;
using System.Collections.Generic;
using ProjectFiles.Code.Models.Entities;
using ProjectFiles.Code.Services;
using ProjectFiles.Code.UI.Models;
using UnityEngine;

public interface IComponentFactory : IService
{
    T CreateComponentFromPrefab<T>() where T : IEntity;
}
