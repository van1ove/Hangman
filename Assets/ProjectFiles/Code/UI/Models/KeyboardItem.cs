using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.UI.Models
{
    public class KeyboardItem : MonoBehaviour
    {
        [SerializeField] private Text textField;
        public char Letter { get; private set; }

        public void Initialize(char letter)
        {
            Letter = letter;
            textField.text = Letter.ToString();
        }
    }
}
