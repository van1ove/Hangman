using System.Linq;
using ProjectFiles.Code.Consts;
using ProjectFiles.Code.Models.Entities;
using ProjectFiles.Code.Models.PrefabModels;
using UnityEngine;
using Random = System.Random;

namespace ProjectFiles.Code.StateMachine.States
{
    public class KeyboardState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly IComponentFactory _componentFactory;
        private readonly GameWords _gameWords;
        private readonly Transform _keyboardTransform;
        private readonly Transform _gameAreaTransform;
        
        private Keyboard _keyboard;
        private Word _word;
        private Hangman _hangman;

        public KeyboardState(GameStateMachine gameStateMachine, IComponentFactory componentFactory, 
            GameWords gameWords, Transform keyboardTransform, Transform gameAreaTransform)
        {
            _gameStateMachine = gameStateMachine;
            _componentFactory = componentFactory;
            _gameWords = gameWords;
            _keyboardTransform = keyboardTransform;
            _gameAreaTransform = gameAreaTransform;
        }
        public void Enter()
        {
            if (_keyboard == null) 
                _keyboard = SpawnKeyboard(_componentFactory.CreateComponentFromPrefab<Keyboard>());
            else
            {
                _keyboard.gameObject.SetActive(true);
                _keyboard.ResetLettersStatus();
            }

            if (_word == null)
                _word = SpawnWord(_componentFactory.CreateComponentFromPrefab<Word>());
            else
            {
                _word.DestroyAllItems();
                Debug.Log(_word.Items.Count);
                SetLettersForWord(_word);
            }

            if (_hangman == null)
            {
                
                _hangman = Object.Instantiate(
                    _componentFactory.CreateComponentFromPrefab<Hangman>(), _gameAreaTransform);
                _hangman.SubscribeToShowResult(_gameStateMachine.Enter<ResultState>);
            }
            _hangman.ResetHangman();
        }

        public void Exit()
        {
            _keyboard.gameObject.SetActive(false);
        }
        
        private Keyboard SpawnKeyboard(Keyboard keyboardExample)
        {
            Keyboard keyboard = Object.Instantiate(keyboardExample, _keyboardTransform);
            
            KeyboardItem keyboardItemPrefab = _componentFactory.CreateComponentFromPrefab<KeyboardItem>();
            foreach (char letter in AlphabetModel.Alphabet)
            {
                keyboardItemPrefab.Initialize(letter);
                
                KeyboardItem keyboardItem = Object.Instantiate(keyboardItemPrefab, keyboard.transform);
            
                keyboardItem.Initialize(letter);
                keyboardItem.SubscribeOnButton(KeyboardItemClick);
                
                keyboard.AddLetterStatus(letter);
            }

            return keyboard;
        }
        
        private Word SpawnWord(Word wordExample)
        {
            Word word = Object.Instantiate(wordExample, _gameAreaTransform);
            return SetLettersForWord(word);
        }

        private Word SetLettersForWord(Word word)
        {
            LetterItem letterPrefab = _componentFactory.CreateComponentFromPrefab<LetterItem>();
            
            Random r = new Random();
            string wordStr = _gameWords.Words[r.Next(0, _gameWords.Words.Count)];
            
            foreach (char letter in wordStr)
            {
                letterPrefab.Initialize(letter);
                LetterItem letterItem = Object.Instantiate(letterPrefab, word.transform);
                letterItem.Initialize(letter);
                word.AddItem(letterItem);
            }

            return word;
        }

        private void KeyboardItemClick(KeyboardItem item)
        {
            if(_keyboard.AlphabetLettersStatus[item.Letter])
                return;
            
            Debug.Log(item.Letter);
            
            bool letterInWord = false;
            foreach (var letterItem in _word.Items.Where(letterItem => letterItem.Letter == item.Letter))
            {
                letterItem.ShowLetter();
                letterInWord = true;
            }
            
            if(!letterInWord)
                _hangman.ShowNextComponent();
            
            _keyboard.AlphabetLettersStatus[item.Letter] = true;
        }
    }
}