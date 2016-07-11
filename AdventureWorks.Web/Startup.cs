using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdventureWorks.Web.Startup))]
namespace AdventureWorks.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
