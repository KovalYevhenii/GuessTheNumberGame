using GuessTheNumber.Interfaces;
namespace GuessTheNumber.Controllers;
internal class GameStarter : IGameStarter
{
    private readonly IGameController _gameController;
    private bool _isGameWon = false;
    public GameStarter(IGameController gameController)
    {
        _gameController = gameController;
    }
    public void StartGame(int rangeFrom, int rangeTo, int attempts)
    {
        Console.WriteLine("=Game Started, Good Luck=");
        while (!_isGameWon)
        {  
            _gameController.InitializeGame(rangeFrom, rangeTo, attempts);

            while (true)
            {
                var userInput = GetIntInput("Enter the number within your range");
                var IsCorrectGuess = _gameController.CheckGuess(userInput);
                switch(IsCorrectGuess)
                {
                    case null:
                        Console.WriteLine("No more attempts, GAME OVER!");
                        return;

                        case true:
                        Console.WriteLine("Congratulations! You guessed the number.");
                        _isGameWon = true;
                        return;

                        case false:
                        var moreOrLess = _gameController.MoreOrLess(userInput);
                        Console.WriteLine($"Sorry,wrong guess try again and {moreOrLess}");
                        break;
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
        rangeFrom = GetIntInput("Enter the range from: ");
        rangeTo = GetIntInput("Enter the range to: ");
        attempts = GetIntInput("Enter the number of attempts: ");
    }
}