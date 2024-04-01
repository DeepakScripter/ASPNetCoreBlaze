using Microsoft.AspNetCore.Hosting; // Importing namespace for hosting ASP.NET Core applications
using Microsoft.Extensions.Configuration; // Importing namespace for configuration
using Microsoft.Extensions.Hosting; // Importing namespace for hosting environment
using Microsoft.Extensions.Logging; // Importing namespace for logging
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuelCostCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // Method to create and configure the host
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args) // Creates a default host builder with preconfigured defaults
                .ConfigureWebHostDefaults(webBuilder => // Configures the web host
                {
                    webBuilder.UseStartup<Startup>(); // Specifies the Startup class to configure the application
                });
    }
}
