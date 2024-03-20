using ProjectFiles.Code.Models;
using ProjectFiles.Code.Models.PrefabModels;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.StateMachine.States
{
    public class ResultState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly IComponentFactory _componentFactory;
        private readonly GameDataModel _gameDataModel;
        private readonly Transform _gameStateTransform;
        private readonly Text _resultText;

        private GameRestarter _gameRestarter;
        
        public ResultState(GameStateMachine gameStateMachine, IComponentFactory componentFactory, 
            GameDataModel gameDataModel,
            Transform gameStateTransform, Text resultText)
        {
            _gameStateMachine = gameStateMachine;
            _componentFactory = componentFactory;
            _gameDataModel = gameDataModel;
            _gameStateTransform = gameStateTransform;
            _resultText = resultText;
        }

        public void Enter()
        {
            CheckGameRestarter();
            _gameRestarter.SetResultText(_gameDataModel.IsPlayerWon);
            _resultText.text = $"Выиграно: {_gameDataModel.VictoriesAmount}. Проиграно: {_gameDataModel.DefeatsAmount}.";
        }

        public void Exit()
        {
            _gameRestarter.gameObject.SetActive(false);
        }

        private void CheckGameRestarter()
        {
            if (_gameRestarter == null)
            {
                _gameRestarter = Object.Instantiate(
                    _componentFactory.CreateComponentFromPrefab<GameRestarter>(), _gameStateTransform);
                _gameRestarter.AddButtonListener(_gameStateMachine.Enter<KeyboardState>);
            }
            else
            {
                _gameRestarter.gameObject.SetActive(true);
            }
        }
    }
}