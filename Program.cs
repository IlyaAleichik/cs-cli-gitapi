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
        static void Main(string[] args)
        {
            Application app = new Application(args);
            app.ApplicationMenu();
            Console.ReadLine();
        }
    }
}
