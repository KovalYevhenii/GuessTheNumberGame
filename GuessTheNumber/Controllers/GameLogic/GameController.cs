using GuessTheNumber.Interfaces;
namespace GuessTheNumber;
internal class GameController : IGameController
{
    private readonly IRandomizer _randomizer;
    private int _targetNumber;
    private int _remainingAttempts;

    public GameController(IRandomizer randomizer)
    {
        _randomizer = randomizer;
    }
    public bool CheckGuess(int guess)
    {
        if (_remainingAttempts <= 0 && _targetNumber != guess)
        {
            throw new Exception("No remaining attempts, Game Over");
        }

        _remainingAttempts--;

        return guess == _targetNumber;
    }
    public void InitializeGame(int rangeFrom, int rangeTo, int attempts)
    {
        _targetNumber = _randomizer.GenerateRandomNumber(rangeFrom, rangeTo);
        _remainingAttempts = attempts - 1;
    }
}