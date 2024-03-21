namespace ProjectFiles.Code.Models
{
    public class GameDataModel
    {
        public int VictoriesAmount { get; private set; }
        public int DefeatsAmount { get; private set; }

        public bool IsPlayerWon { get; private set; }

        public GameDataModel()
        {
            VictoriesAmount = 0;
            DefeatsAmount = 0;
        }

        public void PlayerWon()
        {
            VictoriesAmount++;
            IsPlayerWon = true;
        }

        public void PlayerLost()
        {
            DefeatsAmount++;
            IsPlayerWon = false;
        }
    }
}