using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace aspnetcoreapp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, 
                              IHostingEnvironment env)
        {
            app.Run(context =>
            {
                if (env.IsDevelopment())
                {

                    var x = context.Request.QueryString.Value.Substring(1).Split('&');

                    var queryParams = new Dictionary<string, string>();

                    x.Select(s => s.Split('='))
                        .ToList()
                        .ForEach(ss => queryParams.Add(ss[0], ss[1]));

                    return context.Response.WriteAsync("Hello World! -- " + ToJson(queryParams));
                }
                return context.Response.WriteAsync("In production");
            });
        }

        private string ToJson(Dictionary<string, string> dict)
        {
            return JsonConvert.SerializeObject(dict);
        }
    }
}