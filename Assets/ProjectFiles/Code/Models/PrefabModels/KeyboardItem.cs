using System;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.Models.Entities
{
    public class KeyboardItem : MonoBehaviour, IEntity
    {
        public char Letter { get; private set; }
        
        [SerializeField] private Button button;
        [SerializeField] private Text textField;

        private event Action<KeyboardItem> ButtonClicked;
        
        public void Initialize(char letter)
        {
            Letter = letter;
            textField.text = Letter.ToString();
        }
        
        public void SubscribeOnButton(Action<KeyboardItem> callback) => ButtonClicked += callback;

        private void OnEnable()
        {
            AddButtonListener();
        }

        private void AddButtonListener() => button.onClick.AddListener(InvokeButtonClicked);

        private void InvokeButtonClicked() => ButtonClicked?.Invoke(this);
    }
}
