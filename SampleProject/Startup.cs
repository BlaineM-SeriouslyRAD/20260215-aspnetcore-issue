using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace HostingModel
{
    public class Startup
    {
        public virtual void ConfigureServices(IServiceCollection services)
        {
            services
                .AddControllers();
        }

        public virtual void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment webHostEnvironment, ILoggerFactory loggerFactory, IServiceProvider serviceProvider)
        {
            applicationBuilder.UseRouting();
            applicationBuilder.UseEndpoints(endpointRouteBuilder =>
            {
                endpointRouteBuilder.MapControllerRoute
               (
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}"
               );
            });
        }
    }
}
