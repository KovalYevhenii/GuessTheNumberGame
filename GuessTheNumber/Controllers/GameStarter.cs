using GuessTheNumber.Interfaces;
namespace GuessTheNumber.Controllers;
internal class GameStarter : IGameStarter
{
    private readonly IGameMenu _gameMenu;
    private readonly IGameController _gameController;
    private bool _isGameWon = false;
    public GameStarter(IGameMenu gameMenu, IGameController gameController)
    {
        _gameMenu = gameMenu;
        _gameController = gameController;
    }
    public void StartGame(int rangeFrom, int rangeTo, int attempts)
    {
        while (!_isGameWon)
        {
            if (attempts <= 0)
                throw new ArgumentException("attemt must be more then 0");

            _gameController.InitializeGame(rangeFrom, rangeTo, attempts);

            while (true)
            {
                _gameMenu.StartMenu();
                var userInput = int.Parse(Console.ReadLine());
                var IsCorrectGuess = _gameController.CheckGuess(userInput);
                if (IsCorrectGuess)
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                    _isGameWon = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry,wrong guess try again");
                }
            }
        }
    }
    private int GetIntInput(string prompt)
    {
        Console.WriteLine(prompt);
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out var input))
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                return input;
            }
        }
    }

    public void GetUserInput(out int rangeFrom, out int rangeTo, out int attempts)
    {
        _gameMenu.Greeting();
        rangeFrom = GetIntInput("Enter the range from: ");
        rangeTo = GetIntInput("Enter the range to: ");
        attempts = GetIntInput("Enter the number of attempts: ");
    }
}
