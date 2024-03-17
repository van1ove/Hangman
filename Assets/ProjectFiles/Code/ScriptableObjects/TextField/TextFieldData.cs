using UnityEngine;

namespace ProjectFiles.Code.ScriptableObjects.TextField
{
    [CreateAssetMenu(fileName = "Text Field Data", menuName = "Configs/Text Field Data", order = 0)]
    public class TextFieldData : ScriptableObject
    {
        public TextTarget target;
        public string text;
        
        private void OnValidate()
        {
            SetText();
        }
        
        private void SetText()
        {
            //text = TextsCollectionModel.Pairs[target];
        }
    }
}