using System;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.MonoBehaviorEntities
{
    public class KeyboardItem : MonoBehaviour, IEntity
    {
        [SerializeField] private Button button;
        [SerializeField] private Text textField;
        public char Letter { get; private set; }
        private event Action<KeyboardItem> ButtonClicked;
        
        private void OnEnable()
        {
            AddButtonListener();
        }
        
        public void Initialize(char letter)
        {
            Letter = letter;
            textField.text = Letter.ToString();
        }
        
        public void SubscribeOnButton(Action<KeyboardItem> callback) => ButtonClicked += callback;
        

        private void AddButtonListener() => button.onClick.AddListener(InvokeButtonClicked);

        private void InvokeButtonClicked() => ButtonClicked?.Invoke(this);
    }
}
