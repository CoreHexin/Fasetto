using Fasetto.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Fasetto;

public partial class App : Application
{
    public new static App Current = (App)Application.Current;

    public IServiceProvider Services { get; }

    public App()
    {
        Services = ConfigureServices();
    }

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IDialogService, DialogService>();
        return services.BuildServiceProvider();
    }

}
