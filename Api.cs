using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using cs_cli_gitapi.Models;

namespace cs_cli_gitapi
{
    class Api
    {
        public Api()
        {

        }
        public async Task<string> MakeHTTPCall(Uri url, AuthenticationHeaderValue authHeader)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "request");
            client.DefaultRequestHeaders.Authorization = authHeader;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

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

        public async Task GetRepoGitLab(string key, Uri url)
        {
            string jsonValue = await MakeHTTPCall(url, new AuthenticationHeaderValue("Bearer", key));
            List<RepositoriesGitLab> myDeserializedClass = JsonConvert.DeserializeObject<List<RepositoriesGitLab>>(jsonValue);
            foreach (RepositoriesGitLab item in myDeserializedClass.OrderBy(s => s.Name)) { Console.WriteLine(item.Name); }
            Console.WriteLine(myDeserializedClass.Count);
            Console.ReadLine();
        }

        public async Task GetRepoGitHub(string key, Uri url)
        {
            string jsonValue = await MakeHTTPCall(url, new AuthenticationHeaderValue("Bearer", key));
            List<Root> myDeserializedClass2 = JsonConvert.DeserializeObject<List<Root>>(jsonValue);
            foreach (Root item in myDeserializedClass2.OrderBy(s => s.Name)) { Console.WriteLine(item.Name); }
            Console.WriteLine(myDeserializedClass2.Count);
            Console.ReadLine();
        }
    }
}
