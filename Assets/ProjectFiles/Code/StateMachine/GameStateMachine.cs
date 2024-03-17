using System;
using System.Collections.Generic;
using ProjectFiles.Code.Services.Factories.KeyboardItemFactory;
using ProjectFiles.Code.StateMachine.States;
using ProjectFiles.Code.UI;

namespace ProjectFiles.Code.StateMachine
{
    public class GameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;
        private IState _currentState;

        public GameStateMachine(
            UIHandler uiHandler, IKeyboardItemFactory keyboardItemFactory)
        {
            _states = new Dictionary<Type, IState>
            {
                [typeof(BootstrapState)] = new BootstrapState(this),
                [typeof(LoadResourcesState)] = new LoadResourcesState(this, 
                    uiHandler.KeyboardTransform, keyboardItemFactory),
                [typeof(MenuState)] = new MenuState(this, uiHandler.MenuPanel, uiHandler.PlayButton),
                [typeof(GameState)] = new GameState(this, uiHandler.GamePanel)
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
