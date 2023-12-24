using GuessTheNumber.Controllers.GameLogic;
using GuessTheNumber.Interfaces;
using GuessTheNumber.Services.ConsoleService;
using Microsoft.Extensions.DependencyInjection;
namespace GuessTheNumber.Services;
internal class ServicesConfiguration
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<Random>();
        services.AddSingleton<IRandomizer, Randomizer>();
        services.AddSingleton<IGameController, GameController>();
        services.AddSingleton<IGameStarter, GameStarter>();
        services.AddSingleton<IUserInput, ConsoleUserInput>();
        services.AddSingleton<IUserOutput, ConsoleUserOutput>();
    }
}
