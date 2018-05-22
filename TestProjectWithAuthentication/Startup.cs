using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProjectWithAuthentication.Startup))]
namespace TestProjectWithAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
