using UnityEngine;

namespace ProjectFiles.Code.MonoBehaviorEntities
{
    public class Hangman : MonoBehaviour, IEntity
    {
        private Transform[] _hangmanComponents;
        private int _nextComponentToShowIndex = 1;

        private void OnEnable()
        {
            _hangmanComponents = GetComponentsInChildren<Transform>();
        }

        public void ResetHangman()
        {
            foreach (Transform component in _hangmanComponents)
            {
                if(component == transform) continue;
                component.gameObject.SetActive(false);
            }

            _nextComponentToShowIndex = 1;
        }

        public void ShowNextComponent()
        {
            _hangmanComponents[_nextComponentToShowIndex].gameObject.SetActive(true);
            _nextComponentToShowIndex++;
        }

        public bool CheckShownComponentsAmount() => _nextComponentToShowIndex == _hangmanComponents.Length;
    }
}