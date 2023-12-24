using GuessTheNumber.Interfaces;
namespace GuessTheNumber;
enum GuessResult { Less, Equal, Greater }
internal class GameController : IGameController
{
    private readonly IRandomizer _randomizer;
    private int _targetNumber;
    private int _remainingAttempts;
    public GameController(IRandomizer randomizer)
    {
        _randomizer = randomizer;
    }
    public void InitializeGame(int rangeFrom, int rangeTo, int attempts)
    {
        _targetNumber = _randomizer.GenerateRandomNumber(rangeFrom, rangeTo);
        _remainingAttempts = attempts - 1;
    }
    public bool CanGuess()
    {
        return _remainingAttempts > 0;
    }
    public GuessResult Guess(int guess)
    {
        _remainingAttempts--;

        if (guess < _targetNumber)
        {
            return GuessResult.Less;
        }

        else if (guess > _remainingAttempts)
        {
            return GuessResult.Greater;
        }

        else
        {
            return GuessResult.Equal;
        }
    }
}