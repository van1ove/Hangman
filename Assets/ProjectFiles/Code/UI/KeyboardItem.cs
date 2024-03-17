using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.UI
{
    public class KeyboardItem : MonoBehaviour
    {
        [SerializeField] private Text _textField;
        public char Letter { get; private set; }

        public void Initialize(char letter)
        {
            Letter = letter;
            _textField.text = Letter.ToString();
        }
    }
}
