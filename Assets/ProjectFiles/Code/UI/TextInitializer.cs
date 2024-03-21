using ProjectFiles.Code.Models.TextCollectionModel;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace ProjectFiles.Code.UI
{
    public class TextInitializer : MonoBehaviour
    {
        [SerializeField] private Text textField;
        [SerializeField] private TextTarget textType;
        private string _headerText = "#Текст#";
        private TextsCollectionModel _modelOfTexts;

        [Inject]
        public void Construct(TextsCollectionModel collectionModel)
        {
            _modelOfTexts = collectionModel;
        }
        private void Start()
        {
            _headerText = _modelOfTexts.Pairs[textType];
            textField.text = $"{_headerText}";
        }

        private void OnValidate()
        {
            textField = GetComponent<Text>();
        }
    }
}