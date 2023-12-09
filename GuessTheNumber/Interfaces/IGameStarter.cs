namespace GuessTheNumber.Interfaces
{
    internal interface IGameStarter
    {
        public void StartGame(int rangeFrom, int rangeTo, int attempts);
        public void GetUserInput(out int rangeFrom, out int rangeTo, out int attempts);
    }
}
