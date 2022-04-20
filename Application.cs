using System;
namespace cs_cli_gitapi
{
    class Application
    {
        Api api;
        private string[] paramString { get; set; }
        public Application(string[] param)
        {
            paramString = param;
        }
        public async void ApplicationMenu()
        {
            api = new Api();
            switch (paramString[0])
            {
                case "gitlab":
                    await api.GetRepoGitLab();
                    break;
                case "githab":
                    await api.GetRepoGitHub();
                    break;
            }
        }
    }
}