using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HostingModel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHostBuilder
                hostBuilder =
                    Host
                        .CreateDefaultBuilder(args)
                        .ConfigureWebHostDefaults(webBuilder =>
                        {
                            webBuilder.UseStartup<Startup>();
                        });
            IHost
                _host = hostBuilder.Build();

            _host.Run();
        }
    }
}
