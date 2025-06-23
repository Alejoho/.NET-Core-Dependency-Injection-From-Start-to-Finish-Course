using DIDemoLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = Host.CreateDefaultBuilder();
            builder.ConfigureServices(services =>
            {
                services.AddTransient<IMessages, Messages>();
                services.AddSingleton<Form1>();
            });

            var app = builder.Build();

            try
            {
                ApplicationConfiguration.Initialize();

                var frm = app.Services.GetRequiredService<Form1>();
                Application.Run(frm);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"An error has ocurred: {ex.Message}");
            }
        }
    }
}