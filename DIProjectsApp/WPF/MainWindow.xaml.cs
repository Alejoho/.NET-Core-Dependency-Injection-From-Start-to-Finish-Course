using DIDemoLib;
using Microsoft.Extensions.Configuration;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IConfiguration _config;
        private readonly IMessages _messages;

        public MainWindow(IConfiguration config, IMessages messages)
        {
            InitializeComponent();
            _config = config;
            _messages = messages;

            helloLabel.Text = _messages.SayHello();
            goodByeLabel.Text = _messages.SayGoodBye();
            settingLabel.Text = _config.GetValue<string>("test");
        }
    }
}