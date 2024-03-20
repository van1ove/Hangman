using ProjectFiles.Code.UI.Models;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.Models.Entities
{
    public class LetterItem : MonoBehaviour, IEntity
    {
        [SerializeField] private Text textField;
        public char Letter { get; private set; }

        public void Initialize(char letter)
        {
            Letter = letter;
            textField.text = Letter.ToString();
            textField.gameObject.SetActive(false);
        }

        public void ShowLetter() => textField.gameObject.SetActive(true);
    }
}