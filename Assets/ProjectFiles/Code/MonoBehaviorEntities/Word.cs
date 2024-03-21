using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ProjectFiles.Code.MonoBehaviorEntities
{
    public class Word : MonoBehaviour, IEntity
    {
        public List<LetterItem> Items { get; private set; } = new List<LetterItem>();

        public void AddItem(LetterItem item) => Items.Add(item);

        public bool AllLettersShown() => Items.Count(item => !item.LetterShown) == 0;
        
        public void DestroyAllItems()
        {
            foreach (Transform itemTransform in GetComponentsInChildren<Transform>())
            {
                if(itemTransform == transform) continue;
                Destroy(itemTransform.gameObject);
            }
            Items = new List<LetterItem>();
        }
    }
}