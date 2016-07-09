using System;
using Microsoft.AspNetCore.Mvc;
using Playground.Services;

namespace Playground.Controllers
{
    [RouteAttribute("/hello")]
    public class HelloController : Controller
    {

        public IActionResult Index()
        {
            Console.WriteLine("Entered Hello");

            var queryString = HttpContext.Request.QueryString.Value.Substring(1);
            return Ok("Hello World! -- "
                    + new QueryStringService().ConvertToJson(queryString));
        }
    }
}