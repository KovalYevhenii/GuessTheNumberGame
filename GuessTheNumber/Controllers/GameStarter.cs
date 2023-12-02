using GuessTheNumber.Interfaces;
namespace GuessTheNumber.Controllers;
internal class GameStarter : IGameStarter
{
    private readonly IGameMenu _gameMenu;
    private readonly IGameController _gameController;
    public GameStarter(IGameMenu gameMenu, IGameController gameController)
    {
        _gameMenu = gameMenu;
        _gameController = gameController;
    }
    public void StartGame()
    {
        while (true)
        {
            _gameMenu.Greeting();
            Console.WriteLine("Enter the range from: ");
            var rangeFrom = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the range to: ");
            var rangeTo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of attempts: ");
            var attempts = int.Parse(Console.ReadLine());
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
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry,wrong guess try again");
                }
            } 
        }
    }
}
