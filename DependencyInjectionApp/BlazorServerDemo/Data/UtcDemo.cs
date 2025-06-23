
namespace BlazorServerDemo.Data;

public class UtcDemo : IDemo, IUtcDemo
{
    public DateTime StartupTime { get; init; }
    public int Num { get; set; }

    public UtcDemo()
    {
        StartupTime = DateTime.UtcNow;
    }

}
