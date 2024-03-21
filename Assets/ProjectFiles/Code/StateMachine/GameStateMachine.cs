using System;
using System.Collections.Generic;
using ProjectFiles.Code.Consts;
using ProjectFiles.Code.Models;
using ProjectFiles.Code.Services.GameWordsProvider;
using ProjectFiles.Code.StateMachine.States;
using ProjectFiles.Code.UI.Models;

namespace ProjectFiles.Code.StateMachine
{
    public class GameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;
        private IState _currentState;

        public GameStateMachine(
            UIHandler uiHandler,
            IComponentFactory componentFactory,
            IGameWordsProvider gameWordsProvider, GameDataModel gameDataModel)
        {
            _states = new Dictionary<Type, IState>
            {
                [typeof(LoadMenuPanelState)] = new LoadMenuPanelState(this, 
                    uiHandler.MenuPanel),
                [typeof(LoadGamePanelState)] = new LoadGamePanelState(this, 
                    uiHandler.GamePanel),
                [typeof(KeyboardState)] = new KeyboardState(this, 
                    componentFactory, gameWordsProvider,
                    uiHandler.GameStatesTransform, uiHandler.GameAreaTransform),
                [typeof(ResultState)] = new ResultState(this, 
                    componentFactory, gameDataModel, 
                    uiHandler.GameStatesTransform, uiHandler.ResultText)
            };
        }

        public void Enter<TState>() where TState : IState
        {
            IState newState = ChangeState<TState>();
            newState.Enter();
        }

        private TState ChangeState<TState>() where TState : IState
        {
            _currentState?.Exit();
            TState newState = (TState)_states[typeof(TState)];
            _currentState = newState;

            return newState;
        }
    }
}
