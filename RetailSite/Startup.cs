using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RetailSite.Startup))]
namespace RetailSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
