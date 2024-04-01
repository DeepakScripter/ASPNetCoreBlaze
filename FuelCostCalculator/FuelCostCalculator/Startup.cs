using Microsoft.AspNetCore.Builder; // Importing namespace for application request processing pipeline
using Microsoft.AspNetCore.Hosting; // Importing namespace for hosting ASP.NET Core applications
using Microsoft.Extensions.Configuration; // Importing namespace for configuration
using Microsoft.Extensions.DependencyInjection; // Importing namespace for dependency injection
using Microsoft.Extensions.Hosting; // Importing namespace for hosting environment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuelCostCalculator
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration; // Constructor to initialize IConfiguration
        }

        public IConfiguration Configuration { get; } // Property to access configuration settings

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddRazorRuntimeCompilation(); // Adding MVC services with Razor runtime compilation
            services.AddControllersWithViews(); // Adding controllers and views services
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) // Checking if environment is development
            {
                app.UseDeveloperExceptionPage(); // Using developer exception page
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); // Using error handling middleware
            }
            app.UseStaticFiles(); // Serving static files

            app.UseRouting(); // Enabling routing

            app.UseAuthorization(); // Using authorization middleware

            app.UseEndpoints(endpoints => // Configuring endpoints
            {
                endpoints.MapControllerRoute( // Mapping controller route
                    name: "default",
                    pattern: "{controller=Fuel}/{action=Index}/{id?}"); // Default route
            });
        }
    }
}
