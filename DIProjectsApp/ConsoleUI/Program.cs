using ConsoleUI;
using DIDemoLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHostBuilder builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((_, services) =>
{
    services.AddTransient<IMessages, Messages>();
    services.AddSingleton<App>();
});

var host = builder.Build();

var app = host.Services.GetRequiredService<App>();

try
{
    app.Run();
}
catch (Exception ex)
{

    System.Console.WriteLine($"An error has ocurred: {ex.Message}");
}

