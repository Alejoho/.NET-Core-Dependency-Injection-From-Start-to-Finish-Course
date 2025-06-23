using DIDemoLib;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private readonly IMessages _messages;

        public Form1(IMessages messages)
        {
            InitializeComponent();
            _messages = messages;
        }

        private void showLabelContent_Click(object sender, EventArgs e)
        {
            helloLabel.Text += _messages.SayHello();
            goodByeLabel.Text += _messages.SayGoodBye();
        }
    }
}
