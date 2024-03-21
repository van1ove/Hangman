using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ProjectFiles.Code.MonoBehaviorEntities
{
    public class GameRestarter : MonoBehaviour, IEntity
    {
        [SerializeField] private Text resultText;
        [SerializeField] private Button restartButton;

        private const string PlayerWonText = "ПОБЕДА!!!";
        private const string PlayerLostText = "Они повесили кучерявого Бобби";
        public void AddButtonListener(UnityAction callback) => 
            restartButton.onClick.AddListener(callback);

        public void SetResultText(bool isPlayerWon) =>
            resultText.text = isPlayerWon ? PlayerWonText : PlayerLostText;
    }
}