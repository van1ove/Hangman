using ProjectFiles.Code.Services.Factories.KeyboardItemFactory;
using ProjectFiles.Code.Services.Factories.LetterItemFactory;
using ProjectFiles.Code.Services.Factories.WordFactory;
using ProjectFiles.Code.UI;
using ProjectFiles.Code.UI.Models;
using UnityEngine;

namespace ProjectFiles.Code.StateMachine.States
{
    public class LoadResourcesState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly Transform _keyboardTransform;
        private readonly Transform _wordTransform;
        private readonly IKeyboardItemFactory _keyboardItemFactory;
        private readonly ILetterItemFactory _letterItemFactory;

        public LoadResourcesState(GameStateMachine gameStateMachine, 
            Transform keyboardTransform, Transform wordTransform,
            IKeyboardItemFactory keyboardItemFactory,
            ILetterItemFactory letterItemFactory)
        {
            _gameStateMachine = gameStateMachine;
            _keyboardTransform = keyboardTransform;
            _wordTransform = wordTransform;
            _keyboardItemFactory = keyboardItemFactory;
            _letterItemFactory = letterItemFactory;
        }
        
        public void Enter()
        {
            KeyboardItem keyboardItem = _keyboardItemFactory.CreateKeyboardItem();
            foreach (char letter in AlphabetModel.Alphabet)
            {
                keyboardItem.Initialize(letter);
                Object.Instantiate(keyboardItem, _keyboardTransform);
            }

            string s = "СУНДУК";

            LetterItem letterItem = _letterItemFactory.CreateLetterItem();
            foreach (char letter in s)
            {
                letterItem.Initialize(letter);
                Object.Instantiate(letterItem, _wordTransform);
            }

            _gameStateMachine.Enter<MenuState>();
        }

        public void Exit()
        {
            Debug.Log("Loaded all resources");
        }
        
        
    }
}