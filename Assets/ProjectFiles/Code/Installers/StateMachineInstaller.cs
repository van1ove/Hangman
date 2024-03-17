using System;
using ProjectFiles.Code.StateMachine;
using ProjectFiles.Code.UI;
using ProjectFiles.Code.UI.Models;
using UnityEngine;
using Zenject;

namespace ProjectFiles.Code.Installers
{
    public class StateMachineInstaller : MonoInstaller
    {
        [SerializeField] private UIHandler uiHandler;
        public override void InstallBindings()
        {
            BindUIHandler();
            BindStateMachine();
        }
        
        private void BindUIHandler() => 
            Container.Bind<UIHandler>().FromInstance(uiHandler).AsSingle();
        private void BindStateMachine() => 
            Container.Bind<GameStateMachine>().AsSingle();

        private void OnValidate()
        {
            uiHandler = GetComponent<UIHandler>();
        }
    }
}