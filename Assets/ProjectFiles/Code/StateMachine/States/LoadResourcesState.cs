using ProjectFiles.Code.Services.Factories.KeyboardItemFactory;
using ProjectFiles.Code.UI;
using UnityEngine;

namespace ProjectFiles.Code.StateMachine.States
{
    public class LoadResourcesState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly Transform _parent;
        private readonly IKeyboardItemFactory _keyboardItemFactory;

        public LoadResourcesState(GameStateMachine gameStateMachine, Transform parent,
            IKeyboardItemFactory keyboardItemFactory)
        {
            _gameStateMachine = gameStateMachine;
            _parent = parent;
            _keyboardItemFactory = keyboardItemFactory;
        }
        
        public void Enter()
        {
            KeyboardItem itemModel = _keyboardItemFactory.CreateKeyboardItem();
            foreach (char letter in AlphabetModel.Alphabet)
            {
                itemModel.Initialize(letter);
                Object.Instantiate(itemModel, _parent);
            }
            _gameStateMachine.Enter<MenuState>();
        }

        public void Exit()
        {
            Debug.Log("Loaded all resources");
        }
    }
}