namespace BlazorApp.Data
{
    public interface ICounterService
    {
        int CounterValue { get; set; }

        int GetCurrentCount();
        void IncrementCount(int value);
    }
}