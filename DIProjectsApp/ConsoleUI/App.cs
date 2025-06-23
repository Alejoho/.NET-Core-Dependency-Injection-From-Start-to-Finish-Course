using DIDemoLib;

namespace ConsoleUI;

public class App
{
    private readonly IMessages _messages;

    public App(IMessages messages)
    {
        _messages = messages;
    }

    public void Run()
    {
        System.Console.WriteLine(_messages.SayHello());
        System.Console.WriteLine(_messages.SayGoodBye());
    }
}
