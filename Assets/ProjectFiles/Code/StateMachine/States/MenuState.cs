using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.StateMachine.States
{
    public class MenuState : IState
    {
        private readonly GameObject _menuPanel;
        public MenuState(GameStateMachine gameStateMachine, GameObject menuPanel, Button playButton)
        {
            _menuPanel = menuPanel;
            playButton.onClick.AddListener(gameStateMachine.Enter<GameState>);
        }
        public void Enter()
        {
            Debug.Log("Menu active");
            _menuPanel.SetActive(true);
        }

        public void Exit()
        {
            Debug.Log("quit menu");
            _menuPanel.SetActive(false);
        }
    }
}