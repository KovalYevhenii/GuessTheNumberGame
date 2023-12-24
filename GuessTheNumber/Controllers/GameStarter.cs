using GuessTheNumber.Interfaces;
using GuessTheNumber;
internal class GameStarter : IGameStarter
{
    private readonly IGameController _gameController;
    private readonly IUserOutput _userOutput;
    private readonly IUserInput _userInput;

    public GameStarter(IGameController gameController, IUserOutput userOutput, IUserInput userInput)
    {
        _gameController = gameController;
        _userOutput = userOutput;
        _userInput = userInput;
    }

    public void StartGame()
    {
        _userOutput.ShowMessage("=Game Started, Good Luck=");

        var rangeFrom = GetIntInput("Enter the range from: ");
        var rangeTo = GetIntInput("Enter the range to: ");
        var attempts = GetIntInput("Enter the number of attempts: ");
        _gameController.InitializeGame(rangeFrom, rangeTo, attempts);

        while (true)
        {
            var userInput = GetIntInput("Enter the number within your range");
            if (!_gameController.CanGuess())
            {
                _userOutput.ShowMessage("No more attempts, GAME OVER!");
                break;
            }

            var result = _gameController.Guess(userInput);
            switch (result)
            {
                case GuessResult.Less:
                    _userOutput.ShowMessage("Number is higher");
                    break;
                case GuessResult.Greater:
                    _userOutput.ShowMessage("Number is lower");
                    break;
                case GuessResult.Equal:
                    _userOutput.ShowMessage("Congratulations! You guessed the number.");
                    return; 
            }
        }
    }
    private int GetIntInput(string prompt)
    {
        while (true)
        {
            _userOutput.ShowMessage(prompt);
            if (!int.TryParse(_userInput.GetInput(), out var input))
            {
                _userOutput.ShowMessage("Wrong input");
            }
            else
            {
                return input;
            }
        }
    }
}