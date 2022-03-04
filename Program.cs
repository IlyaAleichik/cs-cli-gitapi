using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.Text.Json;

namespace netcore_cli_webapi_test
{
    class Program
    {

        static async Task<string> MakeHTTPCall(Uri url, AuthenticationHeaderValue authHeader)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = authHeader;

            var response = await client.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                // Authorization header has been set, but the server reports that it is missing.
                // It was probably stripped out due to a redirect.

                var finalRequestUri = response.RequestMessage.RequestUri; // contains the final location after following the redirect.

                if (finalRequestUri != url) // detect that a redirect actually did occur.
                {
                    // If this is public facing, add tests here to determine if Url should be trusted
                    response = await client.GetAsync(finalRequestUri);
                }
            }

            return await response.Content.ReadAsStringAsync();
        }

        static async Task Main(string[] args)
        {
            string jsonValue = "";
            Uri url = new Uri("https://gitlab.com/api/v4/users/IlyaAleichik/projects");
            jsonValue = await MakeHTTPCall(url, new AuthenticationHeaderValue("Bearer", "glpat-xjg9fsxRP9gizt25TfYH"));
            Console.WriteLine(jsonValue);
        }
    }
}
