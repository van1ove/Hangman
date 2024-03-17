using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.UI.Models
{
    public class UIHandler : MonoBehaviour
    {
        [field:Header("Load Resources State")]
        [field: SerializeField] public Transform KeyboardTransform { get; private set; }
        [field: SerializeField] public Transform WordTransform { get; private set; }
        
        [field:Header("Menu State")]
        [field:SerializeField] public GameObject MenuPanel { get; private set; }
        [field:SerializeField] public Button PlayButton { get; private set; }

        [field:Header("Game State")]
        [field:SerializeField] public GameObject GamePanel { get; private set; }
    }
}