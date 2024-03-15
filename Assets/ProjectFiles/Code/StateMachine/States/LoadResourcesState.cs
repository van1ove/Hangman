using ProjectFiles.Code.State;
using UnityEngine;

namespace ProjectFiles.Code.StateMachine.States
{
    public class LoadResourcesState : IState
    {
        private readonly GameStateMachine _gameStateMachine;

        public LoadResourcesState(GameStateMachine gameStateMachine, GameObject startPanel)
        {
            _gameStateMachine = gameStateMachine;
            startPanel.SetActive(true);
        }
        public void Enter()
        {
            Debug.Log("Loading resources");
        }

        public void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}