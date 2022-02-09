using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;


namespace BlazorApp.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;
        [Inject] // You cannot use a constructor in a ComponentBase, since it's ran before the page. You can then Inject with this. 
        public ILogger<CounterBase> Log { get; set; }
        protected void IncrementCount()
        {
            currentCount++;
            Log.LogInformation("The new value is {CounterValue}", currentCount);
        }
    }
}
