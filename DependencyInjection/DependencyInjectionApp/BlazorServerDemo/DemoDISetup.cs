using BlazorServerDemo.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo
{
    public static class DemoDISetup
    {
        public static IServiceCollection AddDemoInfo(this IServiceCollection services)
        {
            services.AddTransient<IDemo, Demo>();
            services.AddTransient<IDemo, UtcDemo>();
            services.AddTransient<ProcessDemo>();

            return services;
        }
    }
}
