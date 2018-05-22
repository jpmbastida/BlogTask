using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BlogTask.Startup))]
namespace BlogTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
