using ProjectFiles.Code.State;
using ProjectFiles.Code.StateMachine.States;
using UnityEngine;

namespace ProjectFiles.Code.StateMachine
{
    public class GameBootstrap : MonoBehaviour
    {
        [SerializeField] private GameObject startPanel;

        private void Awake()
        {
            GameStateMachine stateMachine = new GameStateMachine(startPanel);
            stateMachine.Enter<BootstrapState>();
        }
    }
}