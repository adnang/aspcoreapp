using aspnetcoreapp;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var hostBuilder = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>();

            if (args.Length > 0)    
                hostBuilder.UseEnvironment(args[0]);
            
            hostBuilder.Build().Run();
        }
    }
}
