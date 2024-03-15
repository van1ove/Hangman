using JetBrains.Annotations;
using ProjectFiles.Code.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.UI
{
    public class TextInitializer : MonoBehaviour
    {
        [SerializeField] private Text header;
        [SerializeField] [NotNull] private TextFieldData textFieldData;
        private string _headerText = "#Текст#";

        private void OnValidate()
        {
            header = GetComponent<Text>();
            
            if (textFieldData)
                _headerText = textFieldData.text;
                
            header.text = $"{_headerText}";
        }
    }
}