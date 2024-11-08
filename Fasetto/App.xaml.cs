using Fasetto.Services;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System.Windows;

namespace Fasetto;

public partial class App : Application
{
    public new static App Current = (App)Application.Current;

    public IServiceProvider Services { get; }

    public App()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        Services = ConfigureServices();
    }

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IDialogService, DialogService>();
        return services.BuildServiceProvider();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        Log.Information("应用程序退出");
        Log.CloseAndFlush();
        base.OnExit(e);
    }

}
