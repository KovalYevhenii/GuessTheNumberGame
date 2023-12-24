using GuessTheNumber.Interfaces;
namespace GuessTheNumber.Services.ConsoleService;
public class ConsoleUserOutput : IUserOutput
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
