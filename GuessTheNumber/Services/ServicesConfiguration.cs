using GuessTheNumber.Controllers.GameLogic;
using GuessTheNumber.Controllers;
using GuessTheNumber.Interfaces;
using GuessTheNumber.View;
using Microsoft.Extensions.DependencyInjection;

namespace GuessTheNumber.Services;

internal class ServicesConfiguration : IServicesConfiguration
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<Random>();
        services.AddSingleton<IRandomizer, Randomizer>();
        services.AddSingleton<IGameMenu, GameMenu>();
        services.AddSingleton<IGameController, GameController>();
        services.AddSingleton<IGameStarter, GameStarter>();
    }
}
