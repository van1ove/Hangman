namespace ProjectFiles.Code.State
{
    public class GameStateMachine
    {
        private IState _currentState;

        public GameStateMachine()
        {
            
        }

        public void Enter<TState>() where TState : IState
        {
            
        }

        private void ChangeState<TState>() where TState : IState
        {
            
        }
    }
}
