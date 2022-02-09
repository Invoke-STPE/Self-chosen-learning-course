using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// Chained configuration - you can have multiple configuration systems, and connect them together ( a configuration is just a .json file)
// appsettings.json
// appsettings.<enviroment>.json
// App secrets (secrets.json) - Only runs in development mode (information specific for your machine, like local sql connection string)
// Enviroment Variables
// Command line arguments

// Azure Key vault - a secret valut for tyour secrets.



namespace BlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
