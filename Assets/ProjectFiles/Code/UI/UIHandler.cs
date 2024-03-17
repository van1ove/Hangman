using UnityEngine;
using UnityEngine.UI;

namespace ProjectFiles.Code.UI
{
    public class UIHandler : MonoBehaviour
    {
        [field: SerializeField] public Transform KeyboardTransform { get; private set; }
        [field: SerializeField] public GameObject MenuPanel { get; private set; }
        [field: SerializeField] public GameObject GamePanel { get; private set; }
        [field: SerializeField] public Button PlayButton { get; private set; }
    }
}