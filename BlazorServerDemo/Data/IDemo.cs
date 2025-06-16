
namespace BlazorServerDemo.Data
{
    public interface IDemo
    {
        DateTime StartupTime { get; init; }
        int Num { get; set; }
    }
}