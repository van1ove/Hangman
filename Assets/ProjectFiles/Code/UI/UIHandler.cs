using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.UI
{
    public class UIHandler : MonoBehaviour
    {

        [field:Header("Menu State")]
        [field:SerializeField] public GameObject MenuPanel { get; private set; }

        [field:Header("Load Game State")]
        [field:SerializeField] public GameObject GamePanel { get; private set; }
        
        [field:Header("Game States")]
        [field: SerializeField] public Transform GameStatesTransform { get; private set; }
        [field: SerializeField] public Transform GameAreaTransform { get; private set; }
        [field: SerializeField] public Text ResultText { get; private set; }
    }
}