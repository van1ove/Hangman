using ProjectFiles.Code.ScriptableObjects.TextField;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace ProjectFiles.Code.UI
{
    public class TextInitializer : MonoBehaviour
    {
        [SerializeField] private Text header;
        [SerializeField] private TextTarget textType;
        private string _headerText = "#Текст#";

        private TextsCollectionModel _modelOfTexts;

        [Inject]
        public void Construct(TextsCollectionModel collectionModel)
        {
            _modelOfTexts = collectionModel;
        }
        private void OnEnable()
        {
            _headerText = _modelOfTexts.Pairs[textType];
            header.text = $"{_headerText}";
        }

        private void OnValidate()
        {
            header = GetComponent<Text>();
        }
    }
}