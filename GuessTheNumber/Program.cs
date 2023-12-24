using GuessTheNumber.Interfaces;
using GuessTheNumber.Services;
using Microsoft.Extensions.DependencyInjection;
namespace GuessTheNumber;
internal class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        var serviceConfig = new ServicesConfiguration();
        serviceConfig.ConfigureServices(services);
        var serviceProvider = services.BuildServiceProvider();
        var game = serviceProvider.GetRequiredService<IGameStarter>();

        Console.WriteLine("====Guess The Number Game====");
        game.StartGame();
    }
}