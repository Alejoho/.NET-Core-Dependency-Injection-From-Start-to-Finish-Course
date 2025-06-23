using BlazorServerDemo.Data;

namespace BlazorServerDemo.Tests;

public class ProcessDemoTest
{
    [Fact]
    public void GetDayInMonth_ShouldReturnProperValueInLeapYear()
    {
        DemoTest demoTest = new DemoTest();
        ProcessDemo processDemo = new(demoTest);
        int expected = 29;

        int actual = processDemo.GetDayInMonth();

        Assert.Equal(expected, actual);
    }
}

public class DemoTest : IDemo
{
    public DateTime StartupTime { get; init; }

    public DemoTest()
    {
        StartupTime = DateTime.Parse("02/01/2000");
    }
}
