using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public class ProcessDemo
    {
        private readonly IDemo demo;

        // public ProcessDemo(IServiceProvider service) // IServiceProvider provides ALL of the applications services

        public ProcessDemo(IDemo demo) // IServiceProvider provides ALL of the applications services
        {
            // Always try to avoid the IServiceProvider pattern, it is an anti pattern
            // And it makes unit testing harder.
            this.demo = demo;
        }

        public int GetDaysInMonth()
        {
            IDemo demo = service.GetRequiredService<IDemo>();
            return demo.StartupTime.Month switch
            {
                1 => 31,
                2 => (demo.StartupTime.Year % 4 == 0) ? 29 : 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new IndexOutOfRangeException()
            };
        }
    }
}
