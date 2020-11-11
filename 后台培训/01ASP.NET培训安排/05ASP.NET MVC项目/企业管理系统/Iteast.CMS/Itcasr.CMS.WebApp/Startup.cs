using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Itcasr.CMS.WebApp.Startup))]
namespace Itcasr.CMS.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
