using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubMVC.Startup))]
namespace GitHubMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
