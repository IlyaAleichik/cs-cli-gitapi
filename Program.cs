using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace cs_cli_gitapi
{
    class Program
    {
        static async Task<string> MakeHTTPCall(Uri url, AuthenticationHeaderValue authHeader)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = authHeader;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                var finalRequestUri = response.RequestMessage.RequestUri;
                if (finalRequestUri != url)
                {
                    response = await client.GetAsync(finalRequestUri);
                }
            }
            return await response.Content.ReadAsStringAsync();
        }

        static async Task Main(string[] args)
        {
            Uri url = new Uri("https://gitlab.com/api/v4/users/IlyaAleichik/projects?&per_page=100");
            string jsonValue = await MakeHTTPCall(url, new AuthenticationHeaderValue("Bearer", "glpat-xjg9fsxRP9gizt25TfYH"));
            List<Repositories> myDeserializedClass = JsonConvert.DeserializeObject<List<Repositories>>(jsonValue);
            foreach (Repositories item in myDeserializedClass.OrderBy(s => s.Name)) { Console.WriteLine(item.Name); }
            Console.WriteLine(myDeserializedClass.Count);
            Console.ReadLine();
        }
    }
}
