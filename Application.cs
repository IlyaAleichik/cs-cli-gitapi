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
                    await api.GetRepoGitLab(Constants.GITLAB, new Uri(Constants.GITLAB_API_GETREPO_URL));
                    break;
                case "githab":
                    await api.GetRepoGitHub(Constants.GITHUB, new Uri(Constants.GITHAB_API_GET_PUBLICREPO_URL));
                    break;
            }
        }
    }
}