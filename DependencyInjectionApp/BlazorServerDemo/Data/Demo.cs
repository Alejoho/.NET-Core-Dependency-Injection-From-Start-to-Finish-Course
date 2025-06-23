namespace BlazorServerDemo.Data;

public class Demo : IDemo, ILocalDemo, IDisposable
{
    private readonly ILogger<Demo> _log;
    private static int _sNum = 0;

    public DateTime StartupTime { get; init; }
    public int Num { get; set; }

    public Demo(ILogger<Demo> log)
    {
        StartupTime = DateTime.Now;
        _log = log;
        _sNum++;
        Num = _sNum;
    }

    public void Dispose()
    {
        //Console.WriteLine($"{Num}-Demo ({StartupTime.ToString("hh:mm:ss ffffff")}) was disposed of.");
        //_log.LogError($"{Num}-Demo ({StartupTime.ToString("hh:mm:ss ffffff")}) was disposed of.");
    }
}
