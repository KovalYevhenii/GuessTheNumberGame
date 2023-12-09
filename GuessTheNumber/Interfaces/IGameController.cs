namespace GuessTheNumber.Interfaces;
internal interface IGameController
{
    void InitializeGame(int rangeFrom, int rangeTo, int attempts);
    bool? CheckGuess(int guess);
    string MoreOrLess(int guess);
}
