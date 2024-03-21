using System.Collections.Generic;
using ProjectFiles.Code.Consts;
using UnityEngine;
using Random = System.Random;

namespace ProjectFiles.Code.Services.GameWordsProvider
{
    public class GameWordsProvider : IGameWordsProvider
    {
        private readonly GameWords _gameWords;
        private List<string> _unusedWords;
        
        public GameWordsProvider(GameWords gameWords)
        {
            _gameWords = gameWords;
            _unusedWords = new List<string>(_gameWords.Words);
        }

        public string LoadWord()
        {
            Debug.Log(_unusedWords.Count);
            if (_unusedWords.Count == 0)
            {
                _unusedWords = new List<string>(_gameWords.Words);
                return LoadWord();
            }
            
            Random rand = new Random();
            int randomIndex = rand.Next(0, _unusedWords.Count);
            string result = _unusedWords[randomIndex];
            _unusedWords.RemoveAt(randomIndex);
            return result;
        }
    }
}