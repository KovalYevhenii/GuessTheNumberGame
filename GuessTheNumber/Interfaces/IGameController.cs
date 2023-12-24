namespace GuessTheNumber.Interfaces;
internal interface IGameController
{
    void InitializeGame(int rangeFrom, int rangeTo, int attempts);
    public bool CanGuess();
    public GuessResult Guess(int guess);
}
