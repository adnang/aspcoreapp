using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Playground.Services
{
    public class QueryStringService
    {
        public string ConvertToJson(string queryString)
        {
            var x = queryString.Split('&');

            var queryParams = new Dictionary<string, string>();

            x.Select(s => s.Split('='))
                .ToList()
                .ForEach(ss => queryParams.Add(ss[0], ss[1]));

            return ToJson(queryParams);
        }

        private string ToJson(Dictionary<string, string> dict)
        {
            return JsonConvert.SerializeObject(dict);
        }
    }

}