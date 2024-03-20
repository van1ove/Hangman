using System.Collections.Generic;

namespace ProjectFiles.Code.ScriptableObjects.TextField
{
    public class TextsCollectionModel
    {
        public readonly Dictionary<TextTarget, string> Pairs = new Dictionary<TextTarget, string>()
        {
            [TextTarget.Header] = TextTargetData.HeaderText,
            [TextTarget.Rules] = TextTargetData.RulesText,
            [TextTarget.PlayButton] = TextTargetData.PlayButtonText,
            [TextTarget.RestartButton] = TextTargetData.RestartButtonText,
            [TextTarget.PlayerStatus] = TextTargetData.PlayerStatusData
        };

        private class TextTargetData
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