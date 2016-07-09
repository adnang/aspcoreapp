using System;
using Microsoft.AspNetCore.Mvc;
using Playground.Services;

namespace Playground.Controllers
{
    [RouteAttribute("/hello")]
    public class HelloController : Controller
    {
        private readonly IQueryStringService _queryStringService;

        public HelloController(IQueryStringService queryStringService){
            _queryStringService = queryStringService;
        }

        public IActionResult Index()
        {
            Console.WriteLine("Entered Hello");
            var queryString  = HttpContext.Request.QueryString.Value;
            
            if (queryString.Length <= 1)
                return Ok("Hello World");
            
            var queryPairs = queryString.Substring(1);
            return Ok(_queryStringService.ConvertToJson(queryPairs));
        }
    }
}