using GuessTheNumber.Interfaces;

namespace GuessTheNumber;

internal class ConsoleUserInput : IUserInput
{
    public string GetInput()
    {
        return Console.ReadLine();
    }
}
