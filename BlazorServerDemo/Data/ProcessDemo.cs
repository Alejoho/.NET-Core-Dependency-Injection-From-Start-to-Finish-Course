namespace BlazorServerDemo.Data;

public class ProcessDemo
{
    //private readonly IServiceProvider _serviceProvider;

    public readonly IDemo _demo;

    public ProcessDemo(IDemo demo)
    {
        _demo = demo;
        //_serviceProvider = serviceProvider;
    }

    public int GetDayInMonth()
    {
        //var _demo = _serviceProvider.GetRequiredService<IDemo>();

        return _demo.StartupTime.Month switch
        {
            1 => 31,
            //2 => 28,
            2 => _demo.StartupTime.Year % 4 == 0 ? 29 : 28,
            3 => 31,
            4 => 30,
            5 => 31,
            6 => 30,
            7 => 31,
            8 => 30,
            9 => 31,
            10 => 30,
            11 => 31,
            12 => 30,
            _ => throw new IndexOutOfRangeException()
        };
    }
}