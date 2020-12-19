using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Orus_UserAccessAndManagement.Startup))]
namespace Orus_UserAccessAndManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
