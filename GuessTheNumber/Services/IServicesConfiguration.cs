using Microsoft.Extensions.DependencyInjection;
namespace GuessTheNumber.Services;
internal interface IServicesConfiguration
{
    public void ConfigureServices(IServiceCollection services);
}
