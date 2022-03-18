using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public class UtcDemo : IDemo, IUtcDemo
    {
        public DateTime StartupTime { get; init; }
        public UtcDemo()
        {
            StartupTime = DateTime.UtcNow;
        }

        public void ThisIsAMethodOnlyForLocal()
        {
            
        }
    }
}
