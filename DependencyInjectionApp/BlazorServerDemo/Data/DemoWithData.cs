namespace BlazorServerDemo.Data
{
    public class DemoWithData : IDemoWithData
    {
        public int NumberToRemember { get; init; }

        public DemoWithData(int numberToRemember)
        {
            NumberToRemember = numberToRemember;
        }
    }
}
