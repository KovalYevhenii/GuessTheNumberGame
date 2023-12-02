using GuessTheNumber.Interfaces;
namespace GuessTheNumber.View;
internal class GameMenu : IGameMenu
{
    public void Greeting()
    {
        Console.WriteLine("====Guess The Number Game====");
    }
    public void StartMenu()
    {
        Console.WriteLine("Enter the number within your range");
    }
}
