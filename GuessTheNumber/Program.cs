using GuessTheNumber.Controllers;
using GuessTheNumber.Controllers.GameLogic;
using GuessTheNumber.Interfaces;
using GuessTheNumber.Services;
using GuessTheNumber.View;
using Microsoft.Extensions.DependencyInjection;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            var serviceConfig = new ServicesConfiguration();
            serviceConfig.ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();
            var startGame = serviceProvider.GetRequiredService<IGameStarter>();
            startGame.StartGame();
         
        }
    }
}