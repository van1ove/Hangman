using ProjectFiles.Code.State;
using UnityEngine;

namespace ProjectFiles.Code.StateMachine.States
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        public BootstrapState(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        public void Enter()
        {
            Debug.Log("Entered bootstrap");
            _gameStateMachine.Enter<LoadResourcesState>();
        }

        public void Exit()
        {
            Debug.Log("Leave bootstrap");
        }
    }
}