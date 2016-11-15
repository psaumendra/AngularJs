using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJsProject.Startup))]
namespace AngularJsProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
