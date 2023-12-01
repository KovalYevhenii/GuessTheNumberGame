using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Controllers;
internal class GameMenuController
{
    private readonly IGameMenu _gameMenu;
    private readonly IGameController _gameController;
    public GameMenuController(IGameMenu gameMenu, IGameController gameController)
    {
        _gameMenu = gameMenu;
        _gameController = gameController;
    }
    public void StartGame()
    {
        _gameMenu.Greeting();

    }
}
