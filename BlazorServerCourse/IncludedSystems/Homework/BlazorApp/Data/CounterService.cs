using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class CounterService : ICounterService
    {
        private readonly ILogger<CounterService> logger;

        public int CounterValue { get; set; }

        public CounterService(ILogger<CounterService> logger)
        {
            this.logger = logger;
        }

        public void IncrementCount(int value)
        {
            CounterValue = value;
            logger.LogInformation("Counter Value changed, new value: {newCount}", CounterValue);
        }

        public int GetCurrentCount()
        {
            return CounterValue;
        }
    }
}
