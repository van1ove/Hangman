using UnityEngine;

namespace ProjectFiles.Code.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Text Field Data", menuName = "Configs/Text Field Data", order = 0)]
    public class TextFieldData : ScriptableObject
    {
        public TextTarget target;
        public string text;

        private void OnValidate()
        {
            SetText();
        }
        
        private void SetText()
        {
            text = target switch
            {
                TextTarget.Header => TextTargetData.HeaderText,
                TextTarget.Rules => TextTargetData.RulesText,
                TextTarget.PlayerStatus => TextTargetData.PlayerStatusData,
                TextTarget.PlayButton => TextTargetData.PlayButtonText,
                TextTarget.RestartButton => TextTargetData.RestartButtonText,
                _ => text
            };
        }
        
        private static class TextTargetData
        {
            public const string HeaderText = "Игра ВИСЕЛИЦА";
            public const string RulesText = 
                "После начала игры, выбирайте по одной букве из алфавита. Ваша цель - угадать слово.\n"
                + "С каждой неправильной буквой на экране будет появляться элемент виселицы. " 
                + "Когда виселица целеком появится на экране - то вы проиграли.\n"
                + "Если вы угадаете какую-то букву из слова, то эта буква будет открыта";
            public const string PlayerStatusData = "Выиграно: 0. Проиграно: 0.";
            public const string PlayButtonText = "ИГРАТЬ";
            public const string RestartButtonText = "ИГРАТЬ ЕЩЕ РАЗ";
        }
    }
}