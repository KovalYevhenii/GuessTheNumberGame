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
    public bool? CheckGuess(int guess)
    {
        if (_remainingAttempts <= 0 && _targetNumber != guess)
        {
            return null;
        }

        _remainingAttempts--;

        return guess == _targetNumber;
    }
    public string MoreOrLess(int guess)
    {
        if (guess < _targetNumber)
            return "choose higher number";

        if (guess > _remainingAttempts)
            return "choose lower nuber";
        else
            throw new Exception();

    }
    public void InitializeGame(int rangeFrom, int rangeTo, int attempts)
    {
        _targetNumber = _randomizer.GenerateRandomNumber(rangeFrom, rangeTo);
        _remainingAttempts = attempts - 1;
    }
}