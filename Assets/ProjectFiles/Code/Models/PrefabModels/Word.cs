using System.Collections.Generic;
using ProjectFiles.Code.Models.Entities;
using UnityEngine;

namespace ProjectFiles.Code.Models.PrefabModels
{
    public class Word : MonoBehaviour, IEntity
    {
        public List<LetterItem> Items { get; private set; } = new List<LetterItem>();

        public void AddItem(LetterItem item) =>
            Items.Add(item);

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