using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public class Demo : IDemo, ILocalDemo, IDisposable
    {
        private readonly ILogger<Demo> log;

        public DateTime StartupTime { get; init; }
        public Demo(ILogger<Demo> log)
        {
            StartupTime = DateTime.Now;
            this.log = log;
        }

        public void Dispose()
        {
            log.LogError($"This was disposed");
        }
    }
}
