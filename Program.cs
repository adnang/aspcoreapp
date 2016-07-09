using Playground.App;
using Microsoft.AspNetCore.Hosting;

namespace Playground
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var hostBuilder = new WebHostBuilder()
                .UseKestrel()
                .UseEnvironment(EnvironmentName.Development)
                .UseStartup<Startup>();

            if (args.Length > 0)
                hostBuilder.UseEnvironment(args[0]);

            hostBuilder.Build().Run();
        }
    }
}