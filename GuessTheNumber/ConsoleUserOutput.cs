using GuessTheNumber.Interfaces;
namespace GuessTheNumber;
public class ConsoleUserOutput : IUserOutput
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
