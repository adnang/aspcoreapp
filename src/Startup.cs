using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Playground.App
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app,
                              IHostingEnvironment env)
        {
            app.UseMvc();
            app.Run(context =>
            {
                return context.Response.WriteAsync("In production");
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();
        }
    }
}