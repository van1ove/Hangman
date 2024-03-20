using System.Collections.Generic;
using ProjectFiles.Code.Models.Entities;
using UnityEngine;

namespace ProjectFiles.Code.Models.PrefabModels
{
    public class Keyboard : MonoBehaviour, IEntity
    {
        public Dictionary<char, bool> AlphabetLettersStatus { get; } = new Dictionary<char, bool>();

        public void AddLetterStatus(char letter) =>
            AlphabetLettersStatus.Add(letter, false);

        public void ResetLettersStatus()
        {
            List<char> keys = new List<char>(AlphabetLettersStatus.Keys);

            foreach (char key in keys)
                AlphabetLettersStatus[key] = false;
        }
    }
}