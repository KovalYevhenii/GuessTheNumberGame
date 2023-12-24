using GuessTheNumber.Interfaces;
namespace GuessTheNumber.Services.ConsoleService;
internal class ConsoleUserInput : IUserInput
{
    public string GetInput()
    {
        return Console.ReadLine();
    }
}
