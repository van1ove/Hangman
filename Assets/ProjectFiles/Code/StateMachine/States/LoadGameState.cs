using UnityEngine;

namespace ProjectFiles.Code.StateMachine.States
{
    public class LoadGameState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly GameObject _gamePanel;

        public LoadGameState(GameStateMachine gameStateMachine, GameObject gamePanel)
        {
            _gameStateMachine = gameStateMachine;
            _gamePanel = gamePanel;
        }
        public void Enter()
        {
            Debug.Log("Game started");
            _gamePanel.SetActive(true);
        }

        public void Exit()
        {
            Debug.Log("Game ended");
            _gamePanel.SetActive(false);
        }
    }
}