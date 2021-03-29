using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Nullnes.EF_Core_POC.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://localhost:5010");
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}