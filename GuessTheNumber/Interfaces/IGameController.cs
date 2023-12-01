namespace GuessTheNumber.Interfaces;
internal interface IGameController
{
    void InitalizeGame(int rangeFrom, int rangeTo, int attempts);
    bool CheckGuess(int guess);
}
