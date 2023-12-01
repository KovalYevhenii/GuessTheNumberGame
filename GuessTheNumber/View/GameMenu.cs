using GuessTheNumber.Interfaces;
namespace GuessTheNumber.View;
internal class GameMenu : IGameMenu
{
    public void Greeting()
    {
        Console.WriteLine("====Guess The Number Game====");
     
    }
 
}
