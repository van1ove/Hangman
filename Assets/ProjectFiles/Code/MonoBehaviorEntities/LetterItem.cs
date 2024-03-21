using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.MonoBehaviorEntities
{
    public class LetterItem : MonoBehaviour, IEntity
    {
        [SerializeField] private Text textField;
        public char Letter { get; private set; }
        public bool LetterShown => textField.gameObject.activeSelf;
        
        public void Initialize(char letter)
        {
            Letter = letter;
            textField.text = Letter.ToString();
            textField.gameObject.SetActive(false);
        }

        public void ShowLetter()
        {
            textField.gameObject.SetActive(true);
        }
    }
}