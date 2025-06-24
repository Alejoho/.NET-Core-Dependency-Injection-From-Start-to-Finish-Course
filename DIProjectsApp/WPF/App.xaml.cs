using DIDemoLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = Host.CreateApplicationBuilder();

            builder.Services.AddTransient<IMessages, Messages>();
            builder.Services.AddSingleton<MainWindow>();

            var app = builder.Build();

            var mainFrm = app.Services.GetRequiredService<MainWindow>();

            mainFrm.Show();
        }
    }
}
