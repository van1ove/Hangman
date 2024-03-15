using System;
using System.Collections.Generic;
using ProjectFiles.Code.StateMachine.States;
using UnityEngine;

namespace ProjectFiles.Code.State
{
    public class GameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;
        private IState _currentState;
        
        

        public GameStateMachine(GameObject startPanel)
        {
            _states = new Dictionary<Type, IState>()
            {
                [typeof(BootstrapState)] = new BootstrapState(this),
                [typeof(LoadResourcesState)] = new LoadResourcesState(this, startPanel)
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
